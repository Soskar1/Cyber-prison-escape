using UnityEngine;

namespace Core.Entities
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PhysicsZeroGravityMovement : MonoBehaviour, IMovable
    {
        [SerializeField] private Rigidbody2D _rb2d;
        [SerializeField] private float _speed;

        public void Move(Vector2 direction)
        {
            _rb2d.velocity = direction * _speed * Time.fixedDeltaTime;
        }
    }
}