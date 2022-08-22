using Core.GrabbableObjects.Items;
using UnityEngine;

namespace Core.Tech
{
    public class CrateButton : Technology
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<Crate>() != null)
                Triggered?.Invoke();
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.GetComponent<Crate>() != null)
                Deactivated?.Invoke();
        }
    }
}