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

        static readonly string CONTENT_INFO = "  Player:{0} NPC:{1}";
        static readonly string TEXT_NAME = "Text";
        [Inject] private GameModel mGameModel;
        private void Awake()
        {
            mText = transform.Find(TEXT_NAME).GetComponent<Text>();
        }

        private void Start()
        {
            mGameModel.OnPlayerPosChanged += UpdateView;
            mGameModel.OnNPCPosChanged += UpdateView;
        }

       
        void UpdateView()
        {
            mText.text = string.Format(CONTENT_INFO,
                                    mGameModel.PlayerPos,
                                    mGameModel.NPCPos);
        }
    }
}
