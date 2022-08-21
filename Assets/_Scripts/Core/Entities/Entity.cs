using UnityEngine;

namespace Core.Entities
{
    public abstract class Entity : MonoBehaviour
    {
        private IMovable _movable;

        private void Awake() => _movable = GetComponent<IMovable>();

        public virtual void Move(float direction) => _movable.Move(direction);
    }
}