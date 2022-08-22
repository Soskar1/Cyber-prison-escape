using UnityEngine;

namespace Core.Entities
{
    public class Aiming : MonoBehaviour
    {
        public void LookAt(Vector2 target)
        {
            Vector2 direction = (target - (Vector2)transform.position).normalized;
            float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotZ);
        }
    }
}