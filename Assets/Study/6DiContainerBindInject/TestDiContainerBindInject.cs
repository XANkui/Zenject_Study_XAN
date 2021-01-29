using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDiContainerBindInject : MonoBehaviour
    {
        [Inject]
        private YourClass mYourClass;

        // Start is called before the first frame update
        void Start()
        {
            // 申请DiContainer，绑定类
            var container = new DiContainer();
            container.Bind<YourClass>().AsSingle();

            // 通过 Inject 注入，执行函数
            container.Inject(this);
            mYourClass.YourFunction();

        }

        public class YourClass
        {
            public void YourFunction()
            {
                Debug.Log(GetType() + "/YourFunction()/ DiContainer Bind Inject Test ……");

            }
        }
    }
}
