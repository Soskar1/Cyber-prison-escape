using Core.Weapons.Configuration;
using UnityEngine;

namespace Core.Weapons
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponConfiguration _config;
        [SerializeField] private GameObject _bullet;
        [SerializeField] private Transform _shotPos;
        private float _delay;

        public WeaponConfiguration Config => _config;
        public GameObject Bullet => _bullet;
        public Transform ShotPos => _shotPos;
        public float Delay => _delay;

        private void Awake() => InitializeConfig();
        protected virtual void InitializeConfig() => _delay = _config.delay;

        public virtual void Shoot()
        {

        }
    }
}