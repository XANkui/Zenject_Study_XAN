﻿using System.Collections;
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
        [Inject] private GameModel mGameModel;


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

            if (gameOverSignal.IsWin)
            {
                mGameModel.GameWinCount.Value++;
                ShowGameWinPanel();
            }
            else {
                mGameModel.GameOverCount.Value++;
                ShowGameOverPanel();
            }

            mGameModel.Save();
        }
    }
}
