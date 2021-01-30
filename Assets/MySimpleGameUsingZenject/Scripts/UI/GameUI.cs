using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameUI : MonoBehaviour
    {
        [Inject] private SignalBus mSignalBus;
        [Inject] private GameOverPanel mGameOverPanel;
        [Inject] private GameWinPanel mGameWinPanel;
        [Inject] private GameSaveService mGameSaveService;


        private void Start()
        {
            mSignalBus.Subscribe<GameOverSignal>(OnGameOver);
        }

        public void ShowGameOverPanel() {
            mGameOverPanel.Show();
        }

        public void ShowGameWinPanel()
        {
            mGameWinPanel.Show();
        }

        public void OnGameOver(GameOverSignal gameOverSignal) {
            GameModel gameModel = mGameSaveService.LoadGameModel();

            if (gameOverSignal.IsWin)
            {
                gameModel.GameWinCount++;
                ShowGameWinPanel();
            }
            else {
                gameModel.GameOverCount++;
                ShowGameOverPanel();
            }

            mGameSaveService.SaveGameModel(gameModel);
        }
    }
}
