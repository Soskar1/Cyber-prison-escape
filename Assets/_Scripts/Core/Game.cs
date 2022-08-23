using Core.Pool;
using UnityEngine;

namespace Core
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private BulletPool _bulletPool;

        private void Awake()
        {
            //Player & Player
            Physics2D.IgnoreLayerCollision(3, 3);
            Physics2D.IgnoreLayerCollision(3, 11);

            _bulletPool.InitializePool();
        }
    }
}