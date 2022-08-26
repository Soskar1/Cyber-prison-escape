using System.Collections;
using UnityEngine;

namespace Core
{
    public class EndGame : MonoBehaviour
    {
        [SerializeField] private float _exitTime;

        private void Awake() => StartCoroutine(Exit());

        private IEnumerator Exit()
        {
            yield return new WaitForSeconds(_exitTime);

            Application.Quit();
        }
    }
}