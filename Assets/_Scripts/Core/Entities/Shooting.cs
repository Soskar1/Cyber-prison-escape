using Core.Weapons;
using UnityEngine;

namespace Core.Entities
{
    public class Shooting : MonoBehaviour
    {
        [SerializeField] private Weapon _currentWeapon;
        private bool _needToReload = false;
        private float _timer;

        public Weapon CurrentWeapon { get => _currentWeapon; set => _currentWeapon = value; }

        private void OnEnable() => _needToReload = false;

        private void Update()
        {
            if (!_needToReload)
                return;

            if (_timer <= 0)
                _needToReload = false;
            else
                _timer -= Time.deltaTime;
        }

        public void TryShoot()
        {
            if (_currentWeapon == null)
                return;

            if (_needToReload)
                return;

            _currentWeapon.Shoot();

            _timer = _currentWeapon.Config.delay;
            _needToReload = true;
        }
    }
}