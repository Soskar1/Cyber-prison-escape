using UnityEngine;
using UnityEngine.InputSystem;

namespace Core.Entities.PlayableCharacters
{
    [RequireComponent(typeof(Grabbing))]
    public class Drone : PlayableCharacter
    {
        [SerializeField] private CharacterSwitch _characterSwitch;
        [SerializeField] private Grabbing _grabbing;

        public override void Awake()
        {
            base.Awake();

            if (!IsActive)
                _input.Controls.Drone.Disable();
        }

        private void OnEnable()
        {
            _input.Controls.Drone.Grab.performed += GrabItem;
            _input.Controls.Drone.Release.performed += ReleaseItem;
            _characterSwitch.CharacterSwitching += _grabbing.TryReleaseItem;
        }

        private void OnDisable()
        {
            _input.Controls.Drone.Grab.performed -= GrabItem;
            _input.Controls.Drone.Release.performed -= ReleaseItem;
            _characterSwitch.CharacterSwitching -= _grabbing.TryReleaseItem;
        }

        private void GrabItem(InputAction.CallbackContext ctx) => _grabbing.TryGrabItem();
        private void ReleaseItem(InputAction.CallbackContext ctx) => _grabbing.TryReleaseItem();
    }
}