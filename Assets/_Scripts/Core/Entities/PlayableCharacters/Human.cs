using Core.GrabbableObjects.Weapons;
using Core.Weapons;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Core.Entities.PlayableCharacters
{
    [RequireComponent(typeof(Jumping))]
    [RequireComponent(typeof(Shooting))]
    [RequireComponent(typeof(GroundCheck))]
    [RequireComponent(typeof(Interacting))]
    public class Human : PlayableCharacter
    {
        [SerializeField] private WeaponInventory _inventory;
        [SerializeField] private Aiming _aiming;
        [SerializeField] private Jumping _jumping;
        [SerializeField] private Shooting _shooting;
        [SerializeField] private GroundCheck _groundCheck;
        [SerializeField] private Interacting _interacting;

        public override void Awake()
        {
            base.Awake();

            if (!IsActive)
                _input.Controls.Human.Disable();
        }

        public override void Update()
        {
            base.Update();

            if (!IsActive)
                return;

            if (_shooting.CurrentWeapon != null)
                _aiming.LookAt(_input.GetWorldMousePosition());
        }

        private void OnEnable()
        {
            _input.Controls.Human.Jump.performed += TryJump;
            _input.Controls.Human.Shoot.performed += Shoot;
            _input.Controls.Human.Interact.performed += Interact;
        }

        private void OnDisable()
        {
            _input.Controls.Human.Jump.performed -= TryJump;
            _input.Controls.Human.Shoot.performed -= Shoot;
            _input.Controls.Human.Interact.performed -= Interact;
        }

        private void TryJump(InputAction.CallbackContext ctx)
        {
            if (_groundCheck.CheckForGround())
                _jumping.Jump();
        }

        private void Shoot(InputAction.CallbackContext ctx) => _shooting.TryShoot();

        private void Interact(InputAction.CallbackContext ctx) => _interacting.TryInteract();

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