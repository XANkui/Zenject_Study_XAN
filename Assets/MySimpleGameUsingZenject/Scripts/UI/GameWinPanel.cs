using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameWinPanel : MonoBehaviour
    {
        [Inject] DiContainer mContainer;
        [Inject] SignalBus mSignalBus;

        private void Awake()
        {
            
            mContainer.BindInstance(this);
            Show(false);
            transform.Find("ResetButton").GetComponent<Button>()
                .onClick.AddListener(() => {
                    Show(false);
                    mSignalBus.Fire<GameRestartSignal>();
                });
        }


        public void Show(bool isShow = true)
        {
            this.gameObject.SetActive(isShow);
        }
    }
}
