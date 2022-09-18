using UnityEngine;

namespace Core
{
    public class CrosshairCursor : MonoBehaviour
    {
        [SerializeField] private Input _input;

        private void OnEnable() => Cursor.visible = false;

        private void Update()
        {
            Vector2 mousePos = _input.GetWorldMousePosition();
            transform.position = mousePos;
        }
    }
}