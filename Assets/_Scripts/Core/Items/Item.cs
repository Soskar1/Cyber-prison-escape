using Core.Entities.PlayableCharacters;
using UnityEngine;

namespace Core.Items
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Item : MonoBehaviour, IGrabbable
    {
        [SerializeField] private Rigidbody2D _rb2d;
        [SerializeField] private HingeJoint2D _hingeJoint;

        private bool _isGrabbed = false;
        public bool IsGrabbed => _isGrabbed;

        public Transform GetTransform => transform;

        public void Grab()
        {
            _isGrabbed = true;
            _hingeJoint.enabled = true;
        }

        public void Release()
        {
            _isGrabbed = false;
            _hingeJoint.enabled = false;
        }
    }
}