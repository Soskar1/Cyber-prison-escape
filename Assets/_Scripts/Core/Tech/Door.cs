using UnityEngine;

namespace Core.Tech
{
    public class Door : MonoBehaviour
    {
        [SerializeField] private Technology _tech;
        [SerializeField] private GameObject _door;

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
            _door.SetActive(false);
        }

        private void Close()
        {
            _door.SetActive(true);
        }
    }
}