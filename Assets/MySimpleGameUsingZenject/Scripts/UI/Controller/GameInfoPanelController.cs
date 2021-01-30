using Jamjardavies.Zenject.ViewController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameInfoPanelController : Controller<GameInfoPanel>
    {
        static readonly string CONTENT_INFO = "  Player:{0} NPC:{1}\n" +
                                              "  Win:{2} Over:{3}";

        [Inject] private ViewModel mViewModel;
        [Inject] private GameModel mGameModel;


        public override void Initialise()
        {
            Debug.Log(GetType() + "/Initialise()/ ……");
            UpdateView();

            mViewModel.PlayerPos.OnValueChangedEvent += UpdateView;
            mViewModel.NPCPos.OnValueChangedEvent += UpdateView;
            mGameModel.GameOverCount.OnValueChangedEvent += UpdateView;
            mGameModel.GameWinCount.OnValueChangedEvent += UpdateView;
        }

        public override void OnDestroy()
        {
            Debug.Log(GetType() + "/OnDestroy()/ ……");
        }

        void UpdateView()
        {
            View.MText.text = string.Format(CONTENT_INFO,
                                    mViewModel.PlayerPos.Value,
                                    mViewModel.NPCPos.Value,
                                    mGameModel.GameWinCount.Value,
                                    mGameModel.GameOverCount.Value);
        }
    }
}
