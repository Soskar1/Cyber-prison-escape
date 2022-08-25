using UnityEngine;

namespace Core.Entities.PlayableCharacters
{
    public class Interacting : MonoBehaviour
    {
        private IInteractable _interactableObjectInTrigger;

        public void TryInteract()
        {
            if (_interactableObjectInTrigger != null)
                _interactableObjectInTrigger.Interact();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out IInteractable interactable))
                _interactableObjectInTrigger = interactable;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.GetComponent<IInteractable>() != null)
                _interactableObjectInTrigger = null;
        }
    }
}