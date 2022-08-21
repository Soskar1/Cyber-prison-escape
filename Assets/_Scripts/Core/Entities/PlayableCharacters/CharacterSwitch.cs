using UnityEngine;
using UnityEngine.InputSystem;

namespace Core.Entities.PlayableCharacters
{
    public class CharacterSwitch : MonoBehaviour
    {
        [SerializeField] private Input _input;
        [SerializeField] private PlayableCharacter _human;
        [SerializeField] private PlayableCharacter _drone;

        private void OnEnable()
        {
            _input.Controls.Human.SwitchCharacter.performed += Switch;
            _input.Controls.Drone.SwitchCharacter.performed += Switch;
        }

        private void OnDisable()
        {
            _input.Controls.Human.SwitchCharacter.performed -= Switch;
            _input.Controls.Drone.SwitchCharacter.performed -= Switch;
        }

        private void Switch(InputAction.CallbackContext ctx)
        {
            if (_human.IsActive)
            {
                _human.Deactivate();
                _drone.Activate();

                _input.Controls.Human.Disable();
                _input.Controls.Drone.Enable();
            }
            else
            {
                _drone.Deactivate();
                _human.Activate();

                _input.Controls.Drone.Disable();
                _input.Controls.Human.Enable();
            }
        }
    }
}