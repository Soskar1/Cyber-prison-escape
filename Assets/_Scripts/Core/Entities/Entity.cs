using UnityEngine;

namespace Core.Entities
{
    [RequireComponent(typeof(Flipping))]
    public abstract class Entity : MonoBehaviour
    {
        [SerializeField] protected Flipping _flipping;
        private IMovable _movable;

        public virtual void Awake() => _movable = GetComponent<IMovable>();

        public virtual void Move(Vector2 direction) => _movable.Move(direction);

        public abstract void Die();
    }
}