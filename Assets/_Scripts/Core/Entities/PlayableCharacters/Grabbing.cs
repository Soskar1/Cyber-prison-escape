using Core.GrabbableObjects;
using UnityEngine;

namespace Core.Entities.PlayableCharacters
{
    public class Grabbing : MonoBehaviour
    {
        [SerializeField] private Collider2D _body;
        [SerializeField] private Flipping _flipping;

        [Header("Raycast")]
        [SerializeField] private Transform _grabCheck;
        [SerializeField] private float _distance;
        [SerializeField] private LayerMask _itemLayer;

        private IGrabbable _currentGrabbedItem;

        public void TryGrabItem()
        {
            if (TryGetItem(out IGrabbable item))
            {
                item.Grab();
                item.GetTransform.parent = transform;
                _flipping.Flipped += item.ImitateFlipping;
                Physics2D.IgnoreCollision(_body, item.GetTransform.GetComponent<Collider2D>(), true);
                _currentGrabbedItem = item;
            }
        }

        public void TryReleaseItem()
        {
            if (_currentGrabbedItem == null)
                return;

            _currentGrabbedItem.Release();
            _currentGrabbedItem.GetTransform.parent = null;
            _flipping.Flipped -= _currentGrabbedItem.ImitateFlipping;
            Physics2D.IgnoreCollision(_body, _currentGrabbedItem.GetTransform.GetComponent<Collider2D>(), false);
            _currentGrabbedItem = null;
        }

        private bool TryGetItem(out IGrabbable item)
        {
            item = null;

            RaycastHit2D hitInfo = Physics2D.Raycast(_grabCheck.position, Vector2.down, _distance, _itemLayer);
            if (hitInfo.collider != null)
            {
                item = hitInfo.collider.GetComponent<IGrabbable>();
                return true;
            }

            return false;
        }
    }
}