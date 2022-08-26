using Core.GrabbableObjects.Items;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Core.Tech
{
    public class CrateButton : Technology
    {
        [SerializeField] private Light2D _light;
        [SerializeField] private Transform _firstAreaPoint;
        [SerializeField] private Transform _secondAreaPoint;
        [SerializeField] private LayerMask _crateLayer;
        private Crate _currentCrate;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Crate crate))
            {
                if (_currentCrate != null)
                    return;

                _currentCrate = crate;
                Trigger();
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Crate crate))
            {
                if (_currentCrate == crate)
                {
                    if (CheckForAnotherCrate(out Crate newCrate))
                    {
                        _currentCrate = newCrate;
                        return;
                    }

                    _currentCrate = null;
                    Deactivate();
                }
            }
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

        private bool CheckForAnotherCrate(out Crate newCrate)
        {
            newCrate = null;
            Collider2D overlapInfo = Physics2D.OverlapArea(_firstAreaPoint.position, _secondAreaPoint.position, _crateLayer);

            if (overlapInfo != null)
            {
                newCrate = overlapInfo.GetComponent<Crate>();
                return true;
            }

            return false;
        }
    }
}