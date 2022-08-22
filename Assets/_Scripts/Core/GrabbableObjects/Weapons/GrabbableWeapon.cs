using UnityEngine;

namespace Core.GrabbableObjects.Weapons
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class GrabbableWeapon : GrabbableObject
    {
        [Header("Grabbable Weapon")]
        [SerializeField] private Rigidbody2D _rb2d;
        [SerializeField] private GameObject _bullet;
        [SerializeField] private Transform _shotPos;
        [SerializeField] private float _knockbackPower;
        [SerializeField] private float _delay;
        private float _timer;

        private void Awake() => _timer = _delay;

        private void Update()
        {
            if (!IsGrabbed)
                return;

            if (_timer <= 0)
            {
                Shoot();
                _timer = _delay;
            }
            else
            {
                _timer -= Time.deltaTime;
            }
        }

        public virtual void Shoot()
        {
            //Instantiate(_bullet, _shotPos.position, Quaternion.identity);
            Debug.Log("Выстрел");
            AddKnockback();
        }

        public virtual void AddKnockback()
        {
            if (_flipping.FacingRight)
                _rb2d.AddForce(Vector2.left * _knockbackPower, ForceMode2D.Impulse);
            else
                _rb2d.AddForce(Vector2.right * _knockbackPower, ForceMode2D.Impulse);
        }
    }
}