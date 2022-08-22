using UnityEngine;

namespace Core.GrabbableObjects.Items
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Item : GrabbableObject
    {
        [Header("Item")]
        [SerializeField] private Rigidbody2D _rb2d;
        [SerializeField] private float _grabMass;
        private float _defaultMass;

        private void Awake() => _defaultMass = _rb2d.mass;

        public override void Grab()
        {
            base.Grab();

            _rb2d.mass = _grabMass;
        }

        public override void Release()
        {
            base.Release();

            _rb2d.mass = _defaultMass;
        }
    }
}