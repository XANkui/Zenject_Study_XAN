using Jamjardavies.Zenject.ViewController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameInfoPanel : View
    {
        private Text mText;

        static readonly string TEXT_NAME = "Text";
        
        public Text MText { get => mText; set => mText = value; }

        private void Awake()
        {
            MText = transform.Find(TEXT_NAME).GetComponent<Text>();
        }

        
    }

    
}
