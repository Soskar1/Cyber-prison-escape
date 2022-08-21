using UnityEngine;

namespace Core.Entities
{
    public abstract class Entity : MonoBehaviour
    {
        private IMovable _movable;

        public virtual void Awake() => _movable = GetComponent<IMovable>();

        public virtual void Move(Vector2 direction) => _movable.Move(direction);
    }
}