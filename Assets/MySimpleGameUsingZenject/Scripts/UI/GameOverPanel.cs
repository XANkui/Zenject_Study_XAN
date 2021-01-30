using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameOverPanel : MonoBehaviour
    {
        [Inject] SignalBus mSignalBus;

        private void Awake()
        {
            
            
            Show(false);
            transform.Find("ResetButton").GetComponent<Button>()
                .onClick.AddListener(()=> {
                    Show(false);
                    mSignalBus.Fire<GameRestartSignal>();
                });
        }


        public void Show(bool isShow = true) {
            this.gameObject.SetActive(isShow);
        }
    }
}
