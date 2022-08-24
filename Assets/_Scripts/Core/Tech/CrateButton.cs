using Core.GrabbableObjects.Items;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Core.Tech
{
    public class CrateButton : Technology
    {
        [SerializeField] private SpriteRenderer _renderer;
        [SerializeField] private Light2D _light;
        [SerializeField] private Sprite _triggeredSprite;
        [SerializeField] private Sprite _defaultSprite;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<Crate>() != null)
            {
                _renderer.sprite = _triggeredSprite;
                _light.color = Color.green;
                Triggered?.Invoke();
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.GetComponent<Crate>() != null)
            {
                _renderer.sprite = _defaultSprite;
                _light.color = Color.red;
                Deactivated?.Invoke();
            }
        }
    }
}