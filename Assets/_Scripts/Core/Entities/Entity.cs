using UnityEngine;

namespace Core.Entities
{
    [RequireComponent(typeof(Flipping))]
    public abstract class Entity : MonoBehaviour, IHittable
    {
        [SerializeField] protected Flipping _flipping;
        [SerializeField] private LayerMask _layer;
        private IMovable _movable;

        public LayerMask Layer => _layer;

        public virtual void Awake() => _movable = GetComponent<IMovable>();

        public virtual void Move(Vector2 direction) => _movable.Move(direction);

        public virtual void Hit() => Die();

        public abstract void Die();
    }
}