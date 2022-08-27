using UnityEngine;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace Core.Tech
{
    [RequireComponent(typeof(AudioSource))]
    public abstract class Technology : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _renderer;
        [SerializeField] private Sprite _triggeredSprite;
        [SerializeField] private Sprite _defaultSprite;

        [SerializeField] private AudioSource _source;
        [SerializeField] private List<AudioClip> _clips;

        public Action Triggered;
        public Action Deactivated;

        public virtual void Trigger()
        {
            _renderer.sprite = _triggeredSprite;
            Triggered?.Invoke();
            PlayRandomSound();
        }

        protected virtual void Deactivate()
        {
            _renderer.sprite = _defaultSprite;
            Deactivated?.Invoke();
            PlayRandomSound();
        }

        private void PlayRandomSound()
        {
            var clip = _clips[Random.Range(0, _clips.Count)];
            _source.clip = clip;
            _source.Play();
        }
    }
}