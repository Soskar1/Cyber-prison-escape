using UnityEngine;

namespace Core.Entities.PlayableCharacters
{
    public abstract class PlayableCharacter : Entity
    {
        [SerializeField] private Input _input;
        [SerializeField] private bool _isActive = false;
        public bool IsActive => _isActive;

        public void Activate() => _isActive = true;
        public void Deactivate() => _isActive = false;
    }
}