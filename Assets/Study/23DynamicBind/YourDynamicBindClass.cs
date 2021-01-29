using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class YourDynamicBindClass : MonoBehaviour
    {
        public void YourFunction()
        {
            Debug.Log(GetType() + "/YourFunction()/ Test Dynamic Bind ……");
        }


    }
}
