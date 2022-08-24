using Core.Entities.PlayableCharacters;
using UnityEngine;

namespace Core.Levels
{
    public class EndOfLevel : MonoBehaviour
    {
        private bool _humanReachedTheEnd = false;
        private bool _droneReachedTheEnd = false;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<Human>() != null)
                _humanReachedTheEnd = true;

            if (collision.GetComponent<Drone>() != null)
                _droneReachedTheEnd = true;

            if (collision.GetComponent<PlayableCharacter>() != null)
                if (_humanReachedTheEnd && _droneReachedTheEnd)
                    Debug.Log("Load next level");
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.GetComponent<Human>() != null)
                _humanReachedTheEnd = false;

            if (collision.GetComponent<Drone>() != null)
                _droneReachedTheEnd = false;
        }
    }
}