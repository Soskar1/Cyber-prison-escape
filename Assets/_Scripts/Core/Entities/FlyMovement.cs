using UnityEngine;

namespace Core.Entities.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class FlyMovement : MonoBehaviour, IMovable
    {
        [SerializeField] private Rigidbody2D _rb2d;
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _decceleration;
        [SerializeField] private float _velocityPower;

        public void Move(Vector2 direction)
        {
            Vector2 targetSpeed = direction * _speed;
            Vector2 speedDif = targetSpeed - _rb2d.velocity;
            float accelXRate = (Mathf.Abs(targetSpeed.x) > 0.01f) ? _acceleration : _decceleration;
            float accelYRate = (Mathf.Abs(targetSpeed.y) > 0.01f) ? _acceleration : _decceleration;
            Vector2 movement = new Vector2(
                Mathf.Pow(Mathf.Abs(speedDif.x) * accelXRate, _velocityPower) * Mathf.Sign(speedDif.x),
                Mathf.Pow(Mathf.Abs(speedDif.y) * accelYRate, _velocityPower) * Mathf.Sign(speedDif.y));

            _rb2d.AddForce(movement * Vector2.one);
        }
    }
}