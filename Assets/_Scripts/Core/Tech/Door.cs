using UnityEngine;
using System.Collections.Generic;
using Core.Entities;

namespace Core.Tech
{
    public class Door : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private Technology _tech;
        [SerializeField] private Collider2D _collider;

        [SerializeField] private LayerMask _entityLayer;
        [SerializeField] private Transform _firstAreaPoint;
        [SerializeField] private Transform _secondAreaPoint;
        [SerializeField] private Transform _safePoint;

        private void OnEnable()
        {
            _tech.Triggered += Open;
            _tech.Deactivated += Close;
        }

        private void OnDisable()
        {
            _tech.Triggered -= Open;
            _tech.Deactivated -= Close;
        }

        private void Open()
        {
            _animator.SetTrigger("Open");
            _collider.enabled = false;
        }

        private void Close()
        {
            _animator.SetTrigger("Close");

            if (CheckForEntities(out List<Entity> entities))
                foreach (Entity entity in entities)
                    entity.transform.position = _safePoint.position;

            _collider.enabled = true;
        }

        private bool CheckForEntities(out List<Entity> entities)
        {
            entities = new List<Entity>();

            Collider2D[] overlapInfo = Physics2D.OverlapAreaAll(_firstAreaPoint.position, _secondAreaPoint.position, _entityLayer);

            if (overlapInfo.Length > 0)
            {
                foreach (var collider in overlapInfo)
                    entities.Add(collider.GetComponent<Entity>());

                return true;
            }

            return false;
        }
    }
}