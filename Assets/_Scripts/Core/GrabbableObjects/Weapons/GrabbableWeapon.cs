using Core.Weapons;
using UnityEngine;

namespace Core.GrabbableObjects.Weapons
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class GrabbableWeapon : GrabbableObject
    {
        [Header("Grabbable Weapon")]
        [SerializeField] private Weapon _weapon;
        [SerializeField] private Rigidbody2D _rb2d;
        [SerializeField] private float _knockbackPower;
        private float _timer;

        public Weapon Weapon => _weapon;

        private void Awake() => _timer = _weapon.Delay;

        private void Update()
        {
            if (!IsGrabbed)
                return;

            if (_timer <= 0)
            {
                Shoot();
                _timer = _weapon.Delay;
            }
            else
            {
                _timer -= Time.deltaTime;
            }
        }

        public virtual void Shoot()
        {
            _weapon.Shoot();
            AddKnockback();
        }

        public virtual void AddKnockback()
        {
            if (_flipping.FacingRight)
                _rb2d.AddForce(Vector2.left * _knockbackPower, ForceMode2D.Impulse);
            else
                _rb2d.AddForce(Vector2.right * _knockbackPower, ForceMode2D.Impulse);
        }
    }
}