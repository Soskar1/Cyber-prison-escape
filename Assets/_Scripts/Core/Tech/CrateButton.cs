using Core.GrabbableObjects.Items;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Core.Tech
{
    public class CrateButton : Technology
    {
        [SerializeField] private Light2D _light;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<Crate>() != null)
                Trigger();
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.GetComponent<Crate>() != null)
                Deactivate();
        }

        public override void Trigger()
        {
            _light.color = Color.green;
            base.Trigger();
        }

        protected override void Deactivate()
        {
            _light.color = Color.red;
            base.Deactivate();
        }
    }
}