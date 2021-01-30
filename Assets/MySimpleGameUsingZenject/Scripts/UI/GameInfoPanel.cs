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

        [Inject] PlayerController mPlayerController;
        [Inject] EnemyController mEnemyController;

        private void Awake()
        {
            mText = transform.Find(TEXT_NAME).GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            mText.text = string.Format(CONTENT_INFO, 
                                    mPlayerController.transform.position,
                                    mEnemyController.transform.position);
        }
    }
}
