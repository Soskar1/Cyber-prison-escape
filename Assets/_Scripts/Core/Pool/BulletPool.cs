using Core.Weapons.Projectiles;
using UnityEngine;

namespace Core.Pool
{
    public class BulletPool : MonoBehaviour
    {
        [SerializeField] private int _poolCount;
        [SerializeField] private bool _autoExpand;
        [SerializeField] private Bullet _bullet;
        [SerializeField] private Transform _container;

        private PoolMono<Bullet> _pool;
        public PoolMono<Bullet> Pool { get => _pool; }

        public void InitializePool() => _pool = new PoolMono<Bullet>(_bullet, _poolCount, _autoExpand, _container);
    }
}