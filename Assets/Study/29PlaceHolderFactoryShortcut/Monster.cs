using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class Monster : MonoBehaviour
    {
        public void YourFunction() { 
            Debug.Log(GetType()+ "/YourFunction()/ Test PlaceHolder Factory Shortcut: Create Monster …… ");

        }

        public class YourFactory : PlaceholderFactory<Monster> { }
    }
}
