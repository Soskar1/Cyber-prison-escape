using UnityEngine;

namespace Core.Entities
{
    public class TransformMovement : MonoBehaviour, IMovable
    {
        [SerializeField] private float _speed;

        public void Move(Vector2 direction) => transform.Translate(direction * _speed * Time.deltaTime);
    }
}