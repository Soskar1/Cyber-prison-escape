using Core.GrabbableObjects;
using UnityEngine;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace Core.Entities.PlayableCharacters
{
    [RequireComponent(typeof(AudioSource))]
    public class Grabbing : MonoBehaviour
    {
        [SerializeField] private Collider2D _body;
        [SerializeField] private AudioSource _source;
        [SerializeField] private List<AudioClip> _clips;

        [Header("Raycast")]
        [SerializeField] private Transform _grabCheck;
        [SerializeField] private float _distance;
        [SerializeField] private LayerMask _itemLayer;

        private IGrabbable _currentGrabbedItem;

        public Action ItemGrabed;
        public Action ItemReleased;

        public void TryGrabItem()
        {
            if (TryGetItem(out IGrabbable item))
            {
                item.Grab();
                Physics2D.IgnoreCollision(_body, item.GetTransform.GetComponent<Collider2D>(), true);
                _currentGrabbedItem = item;

                ItemGrabed?.Invoke();
                PlayRandomSound();
            }
        }

        public void TryReleaseItem()
        {
            if (_currentGrabbedItem == null)
                return;

            _currentGrabbedItem.Release();
            Physics2D.IgnoreCollision(_body, _currentGrabbedItem.GetTransform.GetComponent<Collider2D>(), false);
            _currentGrabbedItem = null;

            ItemReleased?.Invoke();
            PlayRandomSound();
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

        private void PlayRandomSound()
        {
            var clip = _clips[Random.Range(0, _clips.Count)];
            _source.clip = clip;
            _source.Play();
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(_grabCheck.position, new Vector2(_grabCheck.position.x, _grabCheck.position.y - _distance));
        }
    }
}