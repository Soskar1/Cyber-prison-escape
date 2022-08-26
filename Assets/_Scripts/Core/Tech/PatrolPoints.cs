using System.Collections.Generic;
using UnityEngine;

namespace Core.Tech
{
    public class PatrolPoints : MonoBehaviour
    {
        [SerializeField] private List<Transform> _patrolPoints;
        [SerializeField] private float _stopDistance;
        private int _currentPoint = 0;

        public Transform CurrentPoint => _patrolPoints[_currentPoint];

        public Transform GetNext()
        {
            _currentPoint = (_currentPoint + 1) % _patrolPoints.Count;
            return _patrolPoints[_currentPoint];
        }

        public bool HasReached()
        {
            if (Vector2.Distance(transform.position, CurrentPoint.position) <= _stopDistance)
                return true;

            return false;
        }
    }
}