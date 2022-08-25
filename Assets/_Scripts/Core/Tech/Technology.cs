using UnityEngine;
using System;

namespace Core.Tech
{
    public abstract class Technology : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _renderer;
        [SerializeField] private Sprite _triggeredSprite;
        [SerializeField] private Sprite _defaultSprite;

        public Action Triggered;
        public Action Deactivated;

        public virtual void Trigger()
        {
            _renderer.sprite = _triggeredSprite;
            Triggered?.Invoke();
        }

        protected virtual void Deactivate()
        {
            _renderer.sprite = _defaultSprite;
            Deactivated?.Invoke();
        }
    }
}