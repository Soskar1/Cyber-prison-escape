using UnityEngine;
using UnityEngine.Rendering.Universal;
using TMPro;

namespace Core.Tech
{
    public class TimerButton : Technology, IInteractable
    {
        [SerializeField] private Light2D _light;
        [SerializeField] private float _time;
        [SerializeField] private TextMeshProUGUI _timerTMPro;
        [SerializeField] private Animator _animator;
        private float _timer;
        private bool _timerStarted = false;

        private int _displayedTime;

        private void Awake()
        {
            _timer = _time;
            _displayedTime = Mathf.RoundToInt(_time);
            _timerTMPro.SetText(_displayedTime.ToString());
        }

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

                if (_displayedTime != Mathf.RoundToInt(_timer))
                {
                    _displayedTime = Mathf.RoundToInt(_timer);
                    _timerTMPro.SetText(_displayedTime.ToString());
                }
            }
        }

        public void Interact() => Trigger();

        public override void Trigger()
        {
            if (_timerStarted)
                return;

            _timerStarted = true;
            _light.color = Color.green;
            _animator.SetTrigger("Started");
            base.Trigger();
        }

        protected override void Deactivate()
        {
            _timerStarted = false;
            _light.color = Color.red;
            _animator.SetTrigger("Ended");
            base.Deactivate();
        }
    }
}