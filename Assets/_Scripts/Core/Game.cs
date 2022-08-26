using Core.Pool;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

namespace Core
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private BulletPool _bulletPool;
        [SerializeField] private Input _input;

        private void Awake()
        {
            Screen.SetResolution(1920, 1080, true);

            //Player & Player
            Physics2D.IgnoreLayerCollision(3, 3);
            Physics2D.IgnoreLayerCollision(3, 11);

            _bulletPool.InitializePool();
        }

        private void OnEnable() => _input.Controls.System.Restart.performed += RestartLevel;
        private void OnDisable() => _input.Controls.System.Restart.performed -= RestartLevel;

        private void RestartLevel(InputAction.CallbackContext ctx) => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}