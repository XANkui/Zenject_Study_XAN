using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameController : MonoBehaviour
    {
        [Inject] private SignalBus mSignalBus;
        [Inject] private NPCController mEnemyController;
        [Inject] private PlayerController mPlayerController;


        private void Start()
        {
            mSignalBus.Subscribe<GameRestartSignal>(OnGameRestart);
            mSignalBus.Subscribe<GameOverSignal>(OnGameOver);
        }

        public void OnGameRestart() {
            mEnemyController.ReStart();
            mPlayerController.ReStart();
        }

        public void OnGameOver(GameOverSignal gameOverSignal) {
            mEnemyController.StopMoving();
            mPlayerController.StopMoving();
        }
    }
}
