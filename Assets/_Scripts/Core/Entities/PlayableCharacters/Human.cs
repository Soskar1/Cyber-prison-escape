using Core.GrabbableObjects.Weapons;
using Core.Weapons;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Core.Entities.PlayableCharacters
{
    [RequireComponent(typeof(Jumping))]
    [RequireComponent(typeof(Shooting))]
    [RequireComponent(typeof(GroundCheck))]
    public class Human : PlayableCharacter
    {
        [SerializeField] private WeaponInventory _inventory;
        [SerializeField] private Jumping _jumping;
        [SerializeField] private Shooting _shooting;
        [SerializeField] private GroundCheck _groundCheck;

        public override void Awake()
        {
            base.Awake();

            if (!IsActive)
                _input.Controls.Human.Disable();
        }

        private void OnEnable()
        {
            _input.Controls.Human.Jump.performed += TryJump;
            _input.Controls.Human.Shoot.performed += Shoot;
        }

        private void OnDisable()
        {
            _input.Controls.Human.Jump.performed -= TryJump;
            _input.Controls.Human.Shoot.performed -= Shoot;
        }

        private void TryJump(InputAction.CallbackContext ctx)
        {
            if (_groundCheck.CheckForGround())
                _jumping.Jump();
        }

        private void Shoot(InputAction.CallbackContext ctx) => _shooting.TryShoot();

        public override void Die()
        {
            gameObject.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out GrabbableWeapon grabbableWeapon))
            {
                _inventory.EquipWeapon(grabbableWeapon.Weapon);
                collision.gameObject.SetActive(false);
            }
        }
    }
}