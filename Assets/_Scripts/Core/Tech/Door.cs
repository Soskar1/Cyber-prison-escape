using UnityEngine;

namespace Core.Tech
{
    public class Door : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private GameObject _door;

        private void OnEnable()
        {
            _button.Pressed += Open;
            _button.Unpressed += Close;
        }

        private void OnDisable()
        {
            _button.Pressed -= Open;
            _button.Unpressed -= Close;
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