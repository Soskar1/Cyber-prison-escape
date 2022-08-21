using UnityEngine;

namespace Core.Entities.PlayableCharacters
{
    public abstract class PlayableCharacter : Entity
    {
        [SerializeField] protected Input _input;
        [SerializeField] private bool _isActive = false;
        public bool IsActive => _isActive;

        private void FixedUpdate()
        {
            if (_isActive)
                Move(_input.GetMovementInput(this));
        }

        public void Activate() => _isActive = true;
        public void Deactivate() => _isActive = false;
    }
}