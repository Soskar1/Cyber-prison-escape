using UnityEngine;

namespace Core.GrabbableObjects
{
    [RequireComponent(typeof(Flipping))]
    [RequireComponent(typeof(HingeJoint2D))]
    public abstract class GrabbableObject : MonoBehaviour, IGrabbable
    {
        [Header("Grabbable Object")]
        [SerializeField] private HingeJoint2D _hingeJoint;

        private bool _isGrabbed = false;
        public bool IsGrabbed => _isGrabbed;
        public Transform GetTransform => transform;

        public virtual void Grab()
        {
            _isGrabbed = true;
            _hingeJoint.enabled = true;
        }

        public virtual void Release()
        {
            _isGrabbed = false;
            _hingeJoint.enabled = false;
        }
    }
}