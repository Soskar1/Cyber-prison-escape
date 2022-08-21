using UnityEngine;

namespace Core.Entities
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Jumping : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rb2d;
        [SerializeField] private float _force;

        [SerializeField] private float _fallGravity;
        private float _defaultGravity;

        private void Awake() => _defaultGravity = _rb2d.gravityScale;

        private void Update()
        {
            if (_rb2d.velocity.y < 0 && _rb2d.gravityScale == _defaultGravity)
                _rb2d.gravityScale = _fallGravity;
            else if (_rb2d.velocity.y >= 0 && _rb2d.gravityScale == _fallGravity)
                _rb2d.gravityScale = _defaultGravity;
        }

        public void Jump() => _rb2d.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
    }
}