using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestConditionBInding : MonoBehaviour
    {
        [Inject] string mStr { get; set; }

        // Start is called before the first frame update
        private void Update()
        {
            { Debug.Log(GetType() + "/Update()/ mStr = " + mStr + " GetHashCode = " + GetHashCode()); }
        }

    }
}