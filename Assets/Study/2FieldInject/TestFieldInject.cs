using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestFieldInject : MonoBehaviour
    {
        /// <summary>
        /// 成员变量注入
        /// 跟 成员 private public 都可
        /// </summary>
        [Inject]
        internal FieldInjectInstaller.YourClass mYourClass;

        // Start is called before the first frame update
        void Start()
        {
            mYourClass.YourFunction();
        }

        
    }
}
