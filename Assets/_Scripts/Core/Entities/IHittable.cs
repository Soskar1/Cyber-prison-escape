using UnityEngine;

namespace Core.Entities
{
    public interface IHittable
    {
        LayerMask Layer { get; }

        void Hit();
    }
}