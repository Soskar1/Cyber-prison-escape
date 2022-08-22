using Core.Entities.PlayableCharacters;
using UnityEngine;

namespace Core.Tech
{
    public class DeathZone : MonoBehaviour
    {
        [SerializeField] private PlayableCharacter _character;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out PlayableCharacter character))
                if (character == _character)
                    character.Die();
        }
    }
}