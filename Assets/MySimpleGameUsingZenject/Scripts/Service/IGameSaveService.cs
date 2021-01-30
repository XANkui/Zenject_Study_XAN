using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MySimpleGameUsingZenject
{
    public interface IGameSaveService 
    {
        void SaveGameModel(GameModel gameModel);
        void LoadGameModel(GameModel gameModel);
    }
}
