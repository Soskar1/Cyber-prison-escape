using Core.Weapons.Projectiles;
using UnityEngine;

namespace Core.Tech
{
    public class Target : Technology
    {
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