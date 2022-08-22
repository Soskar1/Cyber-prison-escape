using UnityEngine;
using UnityEngine.InputSystem;

namespace Core.Entities.PlayableCharacters
{
    [RequireComponent(typeof(Jumping))]
    [RequireComponent(typeof(GroundCheck))]
    public class Human : PlayableCharacter
    {
        [SerializeField] private Jumping _jumping;
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
        }

        private void OnDisable()
        {
            _input.Controls.Human.Jump.performed -= TryJump;
        }

        private void TryJump(InputAction.CallbackContext ctx)
        {
            if (_groundCheck.CheckForGround())
                _jumping.Jump();
        }

        public override void Die()
        {
            gameObject.SetActive(false);
        }
    }
}