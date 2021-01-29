using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestPropertyInject : MonoBehaviour
    {
        /// <summary>
        /// 属性注入
        /// 注意一般跟属性的 private public 等都不要紧
        /// </summary>
        [Inject]
        protected PropertyInjectInstaller.YourClass YourClass { get; private set; }

        // Start is called before the first frame update
        void Start()
        {
            YourClass.YourFunction();
        }

        
    }
}
