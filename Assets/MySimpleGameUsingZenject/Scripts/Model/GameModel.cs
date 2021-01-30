using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameModel:IInitializable
    {
        [Inject] GameSaveService mGameSaveService;

        public int GameOverCount;
        public int GameWinCount;

        public void Save() {
            mGameSaveService.SaveGameModel(this);
        }

        public void Initialize()
        {
            mGameSaveService.LoadGameModel(this);
        }
    }
}
