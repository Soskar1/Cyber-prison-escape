using Core.Entities;
using System.Collections;
using UnityEngine;

namespace Core.Weapons.Projectiles
{
    public abstract class Projectile : MonoBehaviour
    {
        [SerializeField] private float _lifeTime;
        private IMovable _movable;

        private void Awake() => _movable = GetComponent<IMovable>();
        private void OnEnable() => StartCoroutine(StartDeactivation());
        private void OnDisable() => StopCoroutine(StartDeactivation());
        public virtual void Update() => Move();
        public virtual void Move() => _movable.Move(Vector2.right);

        private IEnumerator StartDeactivation()
        {
            yield return new WaitForSeconds(_lifeTime);
            gameObject.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out IHittable entity))
            {
                //entity.Hit();
                gameObject.SetActive(false);
            }    
        }
    }
}