using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestMethodInject : MonoBehaviour
    {
        YourClass mYourClass;

        [Inject]
        public void MethodFunc(YourClass yourClass)
        {
            mYourClass = yourClass;
        }

        // Start is called before the first frame update
        void Start()
        {
            mYourClass.YourFunction();
        }


    }
}
