using UnityEngine;
using System;

namespace Core.Tech
{
    public abstract class Technology : MonoBehaviour
    {
        public Action Triggered;
        public Action Deactivated;
    }
}