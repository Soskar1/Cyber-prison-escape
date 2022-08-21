using UnityEngine;
using UnityEngine.InputSystem;

namespace Core.Entities.PlayableCharacters
{
    public class CharacterSwitch : MonoBehaviour
    {
        [SerializeField] private Input _input;
        [SerializeField] private PlayableCharacter _firstCharacter;
        [SerializeField] private PlayableCharacter _secondCharacter;

        private void OnEnable() => _input.Controls.Player.SwitchCharacter.performed += Switch;
        private void OnDisable() => _input.Controls.Player.SwitchCharacter.performed -= Switch;

        private void Switch(InputAction.CallbackContext ctx)
        {
            if (_firstCharacter.IsActive)
            {
                _firstCharacter.Deactivate();
                _secondCharacter.Activate();
                return;
            }

            _secondCharacter.Deactivate();
            _firstCharacter.Activate();
        }
    }
}