using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using Core.Entities;
using Core.Weapons.Configuration;

namespace Core.Weapons
{
    public class WeaponInventory : MonoBehaviour
    {
        [SerializeField] private Shooting _shooting;

        [SerializeField] private List<Weapon> _weapons = new List<Weapon>();
        private Dictionary<WeaponConfiguration, Weapon> _inventory = new Dictionary<WeaponConfiguration, Weapon>();

        private void Awake()
        {
            for (int index = 0; index < _weapons.Count; index++)
                _inventory.Add(_weapons[index].Config, _weapons[index]);
        }

        public void EquipWeapon(Weapon newWeapon)
        {
            DeactivateAllActiveWeapons();

            if (_inventory.TryGetValue(newWeapon.Config, out Weapon weapon))
            {
                weapon.gameObject.SetActive(true);
                _shooting.CurrentWeapon = weapon;
            }
        }

        private void DeactivateAllActiveWeapons()
        {
            var activeObjects = _weapons.Where(x => x.gameObject.activeSelf);

            foreach (var obj in activeObjects)
                obj.gameObject.SetActive(false);
        }
    }
}