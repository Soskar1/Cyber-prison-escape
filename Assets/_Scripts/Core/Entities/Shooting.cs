using Core.Weapons;
using UnityEngine;

namespace Core.Entities
{
    public class Shooting : MonoBehaviour
    {
        [SerializeField] private Weapon _currentWeapon;

        public Weapon CurrentWeapon { get => _currentWeapon; set => _currentWeapon = value; }

        public void TryShoot()
        {
            if (_currentWeapon != null)
                _currentWeapon.Shoot();
        }
    }
}