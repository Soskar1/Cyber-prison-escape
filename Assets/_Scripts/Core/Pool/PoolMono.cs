using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Pool
{
    public class PoolMono<T> where T : MonoBehaviour
    {
        private T _prefab { get; }
        private bool _autoExpand { get; set; }
        private Transform _container { get; }

        private List<T> _pool;

        public PoolMono(T prefab, int count, bool autoExpand)
        {
            _prefab = prefab;
            _autoExpand = autoExpand;
            _container = null;

            CreatePool(count);
        }

        public PoolMono(T prefab, int count, bool autoExpand, Transform container)
        {
            _prefab = prefab;
            _autoExpand = autoExpand;
            _container = container;

            CreatePool(count);
        }

        private void CreatePool(int count)
        {
            _pool = new List<T>();

            for (int index = 0; index < count; index++)
                CreateObject();
        }

        private T CreateObject(bool isActiveByDefault = false)
        {
            var createdObject = UnityEngine.Object.Instantiate(_prefab, _container);
            createdObject.gameObject.SetActive(isActiveByDefault);
            _pool.Add(createdObject);
            return createdObject;
        }

        public bool HasFreeElement(out T element)
        {
            foreach (var mono in _pool)
            {
                if (!mono.gameObject.activeInHierarchy)
                {
                    element = mono;
                    mono.gameObject.SetActive(true);
                    return true;
                }
            }

            element = null;
            return false;
        }

        public T GetFreeElement()
        {
            if (HasFreeElement(out var element))
                return element;

            if (_autoExpand)
                return CreateObject(true);

            throw new Exception($"There is no free elements in pool of type {typeof(T)}");
        }
    }
}