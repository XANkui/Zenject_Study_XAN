using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDIContainerBindTypeToType : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // 申请DiContainer，绑定约束类型的结果类
            var container = new DiContainer();
            container.Bind<IYourInterface>().To<YourClass>().AsSingle();

            // 解析获取约定类型的类，并执行函数
            var yourClass = container.Resolve<IYourInterface>();
            yourClass.YourFunction();
        }


        public interface IYourInterface {
            void YourFunction();
        }

        public class YourClass : IYourInterface {
            public void YourFunction()
            {
                Debug.Log(GetType() + "/YourFunction()/ DiContainer Bind Type To Type Test ……");
            }
        }
    }
}
