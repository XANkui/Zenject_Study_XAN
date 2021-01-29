using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDiContainnerBindResolve : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // 申请一个 DiContainer
            var container = new DiContainer();

            // 绑定 YourClass，作为单例
            container.Bind<YourClass>().AsSingle();

            // 解析获取 YourClass
            var yourClass = container.Resolve<YourClass>();

            // 执行 获取 YourClass 函数
            yourClass.YourFunction();
        }

        public class YourClass {
            public void YourFunction()
            {
                Debug.Log(GetType() + "/YourFunction()/ DiContainer Bind Resolve Test ……");

            }
        }
    }
}
