using UnityEngine;

namespace Core.Items
{
    public interface IGrabbable
    {
        Transform GetTransform { get; }

        bool IsGrabbed { get; }

        void Grab();

        void Release();
    }
}