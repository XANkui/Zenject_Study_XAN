using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameController : MonoBehaviour
    {
        [Inject] private DiContainer mContainer;
        [Inject] private SignalBus mSignalBus;

        private void Awake()
        {
            mContainer.BindInstance(this);
        }
        private void Start()
        {
            mSignalBus.Subscribe<GameRestartSignal>(OnGameRestart);
            mSignalBus.Subscribe<GameOverSignal>(OnGameOver);
        }

        public void OnGameRestart() {
            mContainer.Resolve<EnemyController>().ReStart();
            mContainer.Resolve<PlayerController>().ReStart();
        }

        public void OnGameOver(GameOverSignal gameOverSignal) {
            mContainer.Resolve<EnemyController>().StopMoving();
            mContainer.Resolve<PlayerController>().StopMoving();
        }
    }
}
