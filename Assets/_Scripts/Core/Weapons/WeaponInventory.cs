using System.Linq;
using System;
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
        [SerializeField] private List<GameObject> _objects = new List<GameObject>();
        private Dictionary<WeaponConfiguration, GameObject> _inventory = new Dictionary<WeaponConfiguration, GameObject>();

        private void Awake()
        {
            if (_weapons.Count != _objects.Count)
                throw new Exception("Weapon count not equal to object count");

            for (int index = 0; index < _weapons.Count; index++)
                _inventory.Add(_weapons[index].Config, _objects[index]);
        }

        public void EquipWeapon(Weapon newWeapon)
        {
            DeactivateAllActiveWeapons();

            if (_inventory.TryGetValue(newWeapon.Config, out GameObject weaponObject))
            {
                weaponObject.SetActive(true);
                _shooting.CurrentWeapon = newWeapon;
            }
        }

        private void DeactivateAllActiveWeapons()
        {
            var activeObjects = _objects.Where(x => x.activeSelf);

            foreach (var obj in activeObjects)
                obj.SetActive(false);
        }
    }
}