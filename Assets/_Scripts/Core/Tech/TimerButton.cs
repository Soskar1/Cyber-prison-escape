using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Core.Tech
{
    public class TimerButton : Technology, IInteractable
    {
        [SerializeField] private Light2D _light;
        [SerializeField] private float _time;
        private float _timer;
        private bool _timerStarted = false;

        private void Awake() => _timer = _time;

        private void Update()
        {
            if (!_timerStarted)
                return;

            if (_timer <= 0)
            {
                Deactivate();
                _timer = _time;
            }
            else
            {
                _timer -= Time.deltaTime;
            }
        }

        public void Interact() => Trigger();

        public override void Trigger()
        {
            if (_timerStarted)
                return;

            _timerStarted = true;
            _light.color = Color.green;
            base.Trigger();
        }

        protected override void Deactivate()
        {
            _timerStarted = false;
            _light.color = Color.red;
            base.Deactivate();
        }
    }
}