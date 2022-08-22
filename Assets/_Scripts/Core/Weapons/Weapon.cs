using Core.Weapons.Configuration;
using Core.Weapons.Projectiles;
using UnityEngine;

namespace Core.Weapons
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponConfiguration _config;
        [SerializeField] private Projectile _projectile;
        [SerializeField] private Transform _shotPos;
        private float _delay;

        public WeaponConfiguration Config => _config;
        public Projectile Projectile => _projectile;
        public Transform ShotPos => _shotPos;
        public float Delay => _delay;

        private void Awake() => InitializeConfig();
        protected virtual void InitializeConfig() => _delay = _config.delay;

        public virtual void Shoot()
        {
            Projectile projectileInstance = Instantiate(_projectile, _shotPos.position, _shotPos.rotation);
            projectileInstance.transform.position = _shotPos.position;
            projectileInstance.transform.rotation = _shotPos.rotation;
        }
    }
}