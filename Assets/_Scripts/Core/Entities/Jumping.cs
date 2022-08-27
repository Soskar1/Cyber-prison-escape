using System.Collections.Generic;
using UnityEngine;

namespace Core.Entities
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(AudioSource))]
    public class Jumping : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rb2d;
        [SerializeField] private AudioSource _source;
        [SerializeField] private List<AudioClip> _clips;
        [SerializeField] private float _force;

        [SerializeField] private float _fallGravity;
        private float _defaultGravity;

        private void Awake() => _defaultGravity = _rb2d.gravityScale;

        private void Update()
        {
            if (_rb2d.velocity.y < 0 && _rb2d.gravityScale == _defaultGravity)
                _rb2d.gravityScale = _fallGravity;
            else if (_rb2d.velocity.y >= 0 && _rb2d.gravityScale == _fallGravity)
                _rb2d.gravityScale = _defaultGravity;
        }

        public void Jump()
        {
            _rb2d.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
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