using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySimpleGameUsingZenject
{
    public class GameSaveService : IGameSaveService
    {
        const string GAME_OVER_COUNT = "GameOverCount";
        const string GAME_WIN_COUNT = "GameWinCount";

        public void SaveGameModel(GameModel gameModel) {
            PlayerPrefs.SetInt(GAME_OVER_COUNT, gameModel.GameOverCount.Value);
            PlayerPrefs.SetInt(GAME_WIN_COUNT, gameModel.GameWinCount.Value);
        }

        public void LoadGameModel(GameModel gameModel) {

            gameModel.GameOverCount.Value = PlayerPrefs.GetInt(GAME_OVER_COUNT, 0);
            gameModel.GameWinCount.Value = PlayerPrefs.GetInt(GAME_WIN_COUNT, 0);
        }
    }
}
