using Core.Entities.PlayableCharacters;
using UnityEngine;

namespace Core.Items
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Item : MonoBehaviour, IGrabbable
    {
        [SerializeField] private Rigidbody2D _rb2d;
        [SerializeField] private HingeJoint2D _hingeJoint;
        [SerializeField] private float _grabMass;
        private float _defaultMass;

        private bool _isGrabbed = false;
        public bool IsGrabbed => _isGrabbed;

        public Transform GetTransform => transform;

        private void Awake() => _defaultMass = _rb2d.mass;

        public void Grab()
        {
            _isGrabbed = true;
            _hingeJoint.enabled = true;

            _rb2d.mass = _grabMass;
        }

        public void Release()
        {
            _isGrabbed = false;
            _hingeJoint.enabled = false;

            _rb2d.mass = _defaultMass;
        }
    }
}