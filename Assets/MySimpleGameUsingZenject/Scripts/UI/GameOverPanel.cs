using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameOverPanel : MonoBehaviour
    {
        [Inject] DiContainer mContainer;

        private void Awake()
        {
            
            mContainer.BindInstance(this);
            Show(false);
            transform.Find("ResetButton").GetComponent<Button>()
                .onClick.AddListener(()=> {
                    Show(false);
                    mContainer.Resolve<GameUI>().GameRestart();
                });
        }


        public void Show(bool isShow = true) {
            this.gameObject.SetActive(isShow);
        }
    }
}
