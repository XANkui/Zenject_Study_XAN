using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class ConditionBindingClass : MonoBehaviour
    {
        [Inject] string mStr;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(GetType() + "/Start()/ mStr = " + mStr + " GetHashCode = " + GetHashCode());

        }


    }
}
