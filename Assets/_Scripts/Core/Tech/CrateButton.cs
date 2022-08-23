using Core.GrabbableObjects.Items;
using UnityEngine;

namespace Core.Tech
{
    public class CrateButton : Technology
    {
        [SerializeField] private SpriteRenderer _renderer;
        [SerializeField] private Sprite _triggeredSprite;
        [SerializeField] private Sprite _defaultSprite;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<Crate>() != null)
            {
                _renderer.sprite = _triggeredSprite;
                Triggered?.Invoke();
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.GetComponent<Crate>() != null)
            {
                _renderer.sprite = _defaultSprite;
                Deactivated?.Invoke();
            }
        }
    }
}