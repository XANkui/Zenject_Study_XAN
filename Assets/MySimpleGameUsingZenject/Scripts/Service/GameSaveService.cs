using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySimpleGameUsingZenject
{
    public class GameSaveService 
    {
        const string GAME_OVER_COUNT = "GameOverCount";
        const string GAME_WIN_COUNT = "GameWinCount";

        public void SaveGameModel(GameModel gameModel) {
            PlayerPrefs.SetInt(GAME_OVER_COUNT, gameModel.GameOverCount);
            PlayerPrefs.SetInt(GAME_WIN_COUNT, gameModel.GameWinCount);
        }

        public void LoadGameModel(GameModel gameModel) {

            gameModel.GameOverCount = PlayerPrefs.GetInt(GAME_OVER_COUNT, 0);
            gameModel.GameWinCount = PlayerPrefs.GetInt(GAME_WIN_COUNT, 0);
        }
    }
}
