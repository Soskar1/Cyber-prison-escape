using Core.Entities;
using UnityEngine;

namespace Core
{
    public class KillArea : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out IHittable entity))
                entity.Hit();
        }
    }
}