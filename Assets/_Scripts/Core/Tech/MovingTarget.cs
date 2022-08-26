using Core.Weapons.Projectiles;
using UnityEngine;

namespace Core.Tech
{
    [RequireComponent(typeof(PatrolPoints))]
    public class MovingTarget : Technology
    {
        [SerializeField] private float _speed;
        [SerializeField] private PatrolPoints _patrolPoints;
        private bool _canMove = true;
        private Transform _target;

        private void Awake() => _target = _patrolPoints.CurrentPoint;

        private void Update()
        {
            if (!_canMove)
                return;

            if (_target == null)
                return;

            transform.Translate(GetMovementDirection() * _speed * Time.deltaTime);

            if (_patrolPoints.HasReached())
                _target = _patrolPoints.GetNext();
        }

        public override void Trigger()
        {
            base.Trigger();
            _canMove = false;
        }

        private Vector2 GetMovementDirection()
        {
            if (_target.position.y > transform.position.y)
                return Vector2.up;

            return Vector2.down;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<Projectile>() != null)
            {
                collision.gameObject.SetActive(false);
                Trigger();
            }
        }
    }
}