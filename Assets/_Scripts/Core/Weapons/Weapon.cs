using Core.Pool;
using Core.Weapons.Configuration;
using Core.Weapons.Projectiles;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Weapons
{
    [RequireComponent(typeof(AudioSource))]
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponConfiguration _config;
        [SerializeField] private BulletPool _pool;
        [SerializeField] private Transform _shotPos;
        [SerializeField] private LayerMask _target;
        private float _delay;

        [SerializeField] private AudioSource _source;
        [SerializeField] private List<AudioClip> _clips;

        public WeaponConfiguration Config => _config;
        public float Delay => _delay;

        private void Awake() => InitializeConfig();
        protected virtual void InitializeConfig() => _delay = _config.delay;

        public virtual void Shoot()
        {
            Bullet bulletInstance = _pool.Pool.GetFreeElement();
            bulletInstance.transform.position = _shotPos.position;
            bulletInstance.transform.rotation = _shotPos.rotation;
            bulletInstance.Initialize(_target);

            PlayRandomSound();
        }

        private void PlayRandomSound()
        {
            var clip = _clips[Random.Range(0, _clips.Count)];
            _source.clip = clip;
            _source.Play();
        }
    }
}