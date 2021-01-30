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
        [Inject] private ViewModel mGameModel;
        [Inject] private GameSaveService mGameSaveService;
        private void Awake()
        {
            mText = transform.Find(TEXT_NAME).GetComponent<Text>();
        }

        private void Start()
        {
            UpdateView(Vector3.zero);

            mGameModel.PlayerPos.OnValueChangedEvent += UpdateView;
            mGameModel.NPCPos.OnValueChangedEvent += UpdateView;
        }

       
        void UpdateView(Vector3 pos)
        {
            mText.text = string.Format(CONTENT_INFO,
                                    mGameModel.PlayerPos.Value,
                                    mGameModel.NPCPos.Value,
                                    mGameSaveService.LoadGameModel().GameWinCount,
                                    mGameSaveService.LoadGameModel().GameOverCount);
        }
    }
}
