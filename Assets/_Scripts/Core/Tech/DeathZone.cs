using Core.Entities.PlayableCharacters;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Core.Tech
{
    public class DeathZone : MonoBehaviour
    {
        [SerializeField] private Technology _tech;
        [SerializeField] private PlayableCharacter _character;
        [SerializeField] private Collider2D _collider;

        [Header("Visual")]
        [SerializeField] private SpriteRenderer _laserRenderer;
        [SerializeField] private GameObject _particles;
        [SerializeField] private Light2D _light;

        private void OnEnable()
        {
            if (_tech != null)
            {
                _tech.Triggered += TurnOff;
                _tech.Deactivated += TurnOn;
            }
        }

        private void OnDisable()
        {
            if (_tech != null)
            {
                _tech.Triggered -= TurnOff;
                _tech.Deactivated -= TurnOn;
            }
        }

        private void TurnOff()
        {
            _collider.enabled = false;
            _laserRenderer.enabled = false;
            _light.enabled = false;
            _particles.SetActive(false);
        }

        private void TurnOn()
        {
            _collider.enabled = true;
            _laserRenderer.enabled = true;
            _light.enabled = true;
            _particles.SetActive(true);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out PlayableCharacter character))
                if (character == _character)
                    character.Die();
        }
    }
}