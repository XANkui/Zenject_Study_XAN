using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameController : MonoBehaviour
    {
        [Inject] private DiContainer mContainer;

        private void Awake()
        {
            mContainer.BindInstance(this);
        }

        public void GameRestart() {
            mContainer.Resolve<EnemyController>().ReStart();
            mContainer.Resolve<PlayerController>().ReStart();
        }

        public void OnGameOve(bool isWin) {
            mContainer.Resolve<GameUI>().OnGameOve(isWin);
        }
    }
}
