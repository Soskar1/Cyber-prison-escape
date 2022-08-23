using Core.Entities;
using System.Collections;
using UnityEngine;

namespace Core.Weapons.Projectiles
{
    public abstract class Projectile : MonoBehaviour
    {
        [SerializeField] private float _lifeTime;
        [SerializeField] private LayerMask _obstacles;
        private LayerMask _targetLayer;
        private IMovable _movable;

        private void Awake() => _movable = GetComponent<IMovable>();
        private void OnEnable() => StartCoroutine(StartDeactivation());
        private void OnDisable() => StopCoroutine(StartDeactivation());
        public virtual void Update() => Move();
        public virtual void Move() => _movable.Move(Vector2.right);

        public void Initialize(LayerMask target) => _targetLayer = target;

        private IEnumerator StartDeactivation()
        {
            yield return new WaitForSeconds(_lifeTime);
            gameObject.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out IHittable entity))
            {
                if (entity.Layer == _targetLayer)
                {
                    entity.Hit();
                    gameObject.SetActive(false);
                }
            }

            if ((_obstacles.value & (1 << collision.gameObject.layer)) > 0)
                gameObject.SetActive(false);
        }
    }
}