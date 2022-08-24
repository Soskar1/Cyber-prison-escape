using Core.Entities.PlayableCharacters;
using UnityEngine;

namespace Core.Levels
{
    public class Hint : MonoBehaviour
    {
        [SerializeField] private GameObject _hint;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<PlayableCharacter>() != null)
                _hint.SetActive(true);
        }
    }
}