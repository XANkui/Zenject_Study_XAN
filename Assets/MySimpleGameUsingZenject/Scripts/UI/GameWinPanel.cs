using Jamjardavies.Zenject.ViewController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameWinPanel : View
    {
        private Button mResetButton;

        public Button ResetButton { get => mResetButton; private set => mResetButton = value; }

        private void Awake()
        {

            ResetButton = transform.Find("ResetButton").GetComponent<Button>();
        }


        public void Show(bool isShow = true)
        {
            this.gameObject.SetActive(isShow);
        }
    }
}
