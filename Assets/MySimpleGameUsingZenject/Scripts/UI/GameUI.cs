using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameUI : MonoBehaviour
    {
        [Inject] private DiContainer mContainer;
        private void Awake()
        {
            mContainer.BindInstance(this);
        }

        public void ShowGameOverPanel() {
            mContainer.Resolve<GameOverPanel>().Show();
        }

        public void ShowGameWinPanel()
        {
            mContainer.Resolve<GameWinPanel>().Show();
        }

        public void GameRestart() {
            mContainer.Resolve<GameController>().GameRestart();
        }

        public void OnGameOve(bool isWin) {
            if (isWin)
            {
                ShowGameWinPanel();
            }
            else {
                ShowGameOverPanel();
            }
        }
    }
}
