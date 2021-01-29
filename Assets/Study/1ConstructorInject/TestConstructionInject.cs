using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestConstructionInject : MonoBehaviour
    {
        private ConstructionInjectInstaller.YourClass mYourClass;

        /// <summary>
        /// 构造函数注入方式
        /// </summary>
        /// <param name="yourClass"></param>
        [Inject]
        void Construction(ConstructionInjectInstaller.YourClass yourClass) {
            mYourClass = yourClass;
        }

        // Start is called before the first frame update
        void Start()
        {
            mYourClass.YourFunction();
        }

        
    }
}
