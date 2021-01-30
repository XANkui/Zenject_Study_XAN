using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameUI : MonoBehaviour
    {
        [Inject] private DiContainer mContainer;
        [Inject] private SignalBus mSignalBus;
        private void Awake()
        {
            mContainer.BindInstance(this);
        }

        private void Start()
        {
            mSignalBus.Subscribe<GameOverSignal>(OnGameOver);
        }

        public void ShowGameOverPanel() {
            mContainer.Resolve<GameOverPanel>().Show();
        }

        public void ShowGameWinPanel()
        {
            mContainer.Resolve<GameWinPanel>().Show();
        }

        public void OnGameOver(GameOverSignal gameOverSignal) {
            if (gameOverSignal.IsWin)
            {
                ShowGameWinPanel();
            }
            else {
                ShowGameOverPanel();
            }
        }
    }
}
