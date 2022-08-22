using UnityEngine;

namespace Core.GrabbableObjects
{
    public interface IGrabbable
    {
        Transform GetTransform { get; }

        bool IsGrabbed { get; }

        void Grab();

        void Release();

        void FlipObject();
    }
}