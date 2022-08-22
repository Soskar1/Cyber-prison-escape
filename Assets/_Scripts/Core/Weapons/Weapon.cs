using Core.Pool;
using Core.Weapons.Configuration;
using Core.Weapons.Projectiles;
using UnityEngine;

namespace Core.Weapons
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponConfiguration _config;
        [SerializeField] private Bullet _bullet;
        [SerializeField] private BulletPool _pool;
        [SerializeField] private Transform _shotPos;
        private float _delay;

        public WeaponConfiguration Config => _config;
        public float Delay => _delay;

        private void Awake() => InitializeConfig();
        protected virtual void InitializeConfig() => _delay = _config.delay;

        public virtual void Shoot()
        {
            Bullet bulletInstance = _pool.Pool.GetFreeElement();
            bulletInstance.transform.position = _shotPos.position;
            bulletInstance.transform.rotation = _shotPos.rotation;
        }
    }
}