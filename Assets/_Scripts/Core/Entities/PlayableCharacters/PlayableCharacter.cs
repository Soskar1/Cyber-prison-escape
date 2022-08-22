using UnityEngine;

namespace Core.Entities.PlayableCharacters
{
    public abstract class PlayableCharacter : Entity
    {
        [SerializeField] protected Input _input;
        [SerializeField] private bool _isActive = false;
        public bool IsActive => _isActive;

        private Vector2 _movementInput;

        private void Update()
        {
            if (!_isActive)
                return;

            _movementInput = _input.GetMovementInput(this);

            if (_flipping.FacingRight && _movementInput.x < 0 ||
                !_flipping.FacingRight && _movementInput.x > 0)
                _flipping.Flip();
        }

        private void FixedUpdate()
        {
            if (_isActive)
                Move(_movementInput);
        }

        public void Activate() => _isActive = true;
        public void Deactivate() => _isActive = false;
    }
}