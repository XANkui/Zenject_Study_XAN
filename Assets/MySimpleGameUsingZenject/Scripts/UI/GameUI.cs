using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameUI : MonoBehaviour
    {
        [Inject] private SignalBus mSignalBus;
        [Inject] private GameModel mGameModel;
        [Inject] private DiContainer mContainer;
        [Inject] private UIManager mUIManager;

        private void Start()
        {
            mSignalBus.Subscribe<GameOverSignal>(OnGameOver);
            mUIManager.OpenPanel<GameInfoPanelController>();
        }

  

        public void OnGameOver(GameOverSignal gameOverSignal) {

            if (gameOverSignal.IsWin)
            {
                mGameModel.GameWinCount.Value++;
                mUIManager.OpenPanel<GameWinPanelController>().View.Show();
            }
            else {
                mGameModel.GameOverCount.Value++;
                mUIManager.OpenPanel<GameOverPanelController>().View.Show();
            }

            mGameModel.Save();
        }
    }
}
