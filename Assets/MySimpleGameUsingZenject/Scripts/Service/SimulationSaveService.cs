using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySimpleGameUsingZenject
{
    /// <summary>
    /// 模拟数据
    /// （方便测试）
    /// </summary>
    public class SimulationSaveService : IGameSaveService
    {

        public void SaveGameModel(GameModel gameModel)
        {
        }

        public void LoadGameModel(GameModel gameModel)
        {
            gameModel.GameOverCount.Value = 100;
            gameModel.GameWinCount.Value = 50;
        }
    }
}
