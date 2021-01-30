using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameModel:IInitializable
    {
        [Inject] IGameSaveService mGameSaveService;

        public Property<int> GameOverCount = new Property<int>();
        public Property<int> GameWinCount = new Property<int>();

        public void Save() {
            mGameSaveService.SaveGameModel(this);
        }

        public void Initialize()
        {
            mGameSaveService.LoadGameModel(this);
        }
    }
}
