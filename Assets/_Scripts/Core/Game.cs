using Core.Entities.PlayableCharacters;
using UnityEngine;

namespace Core
{
    public class Game : MonoBehaviour
    {
        private void Awake()
        {
            //Player & Player
            Physics2D.IgnoreLayerCollision(3, 3);
        }
    }
}