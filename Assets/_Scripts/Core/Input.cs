using UnityEngine;
using Core.Entities.PlayableCharacters;

namespace Core
{
    public class Input : MonoBehaviour
    {
        private Controls _controls;
        public Controls Controls => _controls;

        private void Awake() => _controls = new Controls();
        private void OnEnable() => _controls.Enable();
        private void OnDisable() => _controls.Disable();

        public Vector2 GetMovementInput(PlayableCharacter character)
        {
            if (character.name == "Human")
                return _controls.Human.Movement.ReadValue<Vector2>();
            else if (character.name == "Drone")
                return _controls.Drone.Movement.ReadValue<Vector2>();

            return Vector2.zero;
        }
    }
}