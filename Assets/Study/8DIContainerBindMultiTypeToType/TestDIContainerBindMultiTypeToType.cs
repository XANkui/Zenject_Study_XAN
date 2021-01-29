using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDIContainerBindMultiTypeToType : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // 申请DiContainer，绑定多个约束类型的结果类
            var container = new DiContainer();
            container.Bind(typeof(IYourInterface),
                typeof(AbsYourClass), 
                typeof(YourClass))
                .To<YourClass>().AsSingle();


            container.Resolve<IYourInterface>().YourFunction();
            container.Resolve<AbsYourClass>().YourFunction();
            container.Resolve<YourClass>().YourFunction();
        }

        public interface IYourInterface
        {
            void YourFunction();
        }

        public abstract class AbsYourClass : IYourInterface{
            public abstract void YourFunction();
        }
        public class YourClass : AbsYourClass
        {
            public override void YourFunction()
            {
                Debug.Log(GetType() + "/YourFunction()/ DiContainer Bind Multi Type To Type Test ……");
            }
        }
    }
}
