using UnityEngine;
using System;

namespace Core.Tech
{
    public abstract class Button : MonoBehaviour
    {
        public Action Pressed;
        public Action Unpressed;
    }
}