using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace Core
{
    public class Level : MonoBehaviour
    {
        [SerializeField] private Input _input;
        [SerializeField] private Animator _animator;

        private void OnEnable() => _input.Controls.System.Restart.performed += SystemRestartLevel;
        private void OnDisable() => _input.Controls.System.Restart.performed -= SystemRestartLevel;

        private void SystemRestartLevel(InputAction.CallbackContext ctx) => SetRestartTrigger();

        public void SetEndTrigger() => _animator.SetTrigger("End");
        public void SetRestartTrigger() => _animator.SetTrigger("Restart");

        public void RestartCurrentLevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        public void LoadNextLevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}