using Core.Items;
using UnityEngine;

namespace Core.Tech
{
    public class CrateButton : Button
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<Crate>() != null)
                Pressed?.Invoke();
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.GetComponent<Crate>() != null)
                Unpressed?.Invoke();
        }
    }
}