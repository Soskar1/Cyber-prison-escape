using UnityEngine;

namespace Core.Tech
{
    public class Door : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private Technology _tech;

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
        }

        private void Close()
        {
            _animator.SetTrigger("Close");
        }
    }
}