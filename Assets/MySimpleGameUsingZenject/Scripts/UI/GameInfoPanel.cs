using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameInfoPanel : MonoBehaviour
    {
        private Text mText;

        static readonly string CONTENT_INFO = "  Player:{0} NPC:{1}\n" +
                                              "  Win:{2} Over:{3}";
        static readonly string TEXT_NAME = "Text";
        [Inject] private ViewModel mViewModel;
        [Inject] private GameModel mGameModel;
        private void Awake()
        {
            mText = transform.Find(TEXT_NAME).GetComponent<Text>();
        }

        private void Start()
        {
            UpdateView();

            mViewModel.PlayerPos.OnValueChangedEvent += UpdateView;
            mViewModel.NPCPos.OnValueChangedEvent += UpdateView;
            mGameModel.GameOverCount.OnValueChangedEvent += UpdateView;
            mGameModel.GameWinCount.OnValueChangedEvent += UpdateView;
        }

       
        void UpdateView()
        {
            mText.text = string.Format(CONTENT_INFO,
                                    mViewModel.PlayerPos.Value,
                                    mViewModel.NPCPos.Value,
                                    mGameModel.GameWinCount.Value,
                                    mGameModel.GameOverCount.Value);
        }
    }
}
