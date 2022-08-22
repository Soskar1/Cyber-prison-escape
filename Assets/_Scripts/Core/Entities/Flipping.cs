using UnityEngine;
using System;

namespace Core
{
    public class Flipping : MonoBehaviour
    {
        [SerializeField] private bool _facingRight = true;
        public bool FacingRight { get => _facingRight; set => _facingRight = value; }

        private Transform _transform;
        private Vector3 _visualRotation = new Vector3(0, 180, 0);

        public Action Flipped;

        private void Awake() => _transform = transform;

        public void Flip()
        {
            _facingRight = !_facingRight;

            transform.Rotate(_visualRotation);

            Flipped?.Invoke();
        }

        public void FaceTheTarget(Vector2 target)
        {
            if (FacingRight && target.x < _transform.position.x ||
                !FacingRight && target.x > _transform.position.x)
                Flip();
        }

        public void FaceTheTarget(Transform target) => FaceTheTarget(target.position);
    }
}