using UnityEngine;

namespace Core
{
    public class Input : MonoBehaviour
    {
        private Controls _controls;
        public Controls Controls => _controls;

        private float _movementInput;
        public float MovementInput => _movementInput;

        private void Awake() => _controls = new Controls();
        private void OnEnable() => _controls.Enable();
        private void OnDisable() => _controls.Disable();

        private void Update() => _movementInput = _controls.Player.Movement.ReadValue<float>();
    }
}