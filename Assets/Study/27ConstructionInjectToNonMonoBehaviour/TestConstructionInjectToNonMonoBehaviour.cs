using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestConstructionInjectToNonMonoBehaviour : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var container = new DiContainer();
            container.BindInstance(new YourNonMonoClass()).AsSingle();
            container.BindInterfacesAndSelfTo<YourClass>().AsSingle();

            container.Resolve<YourClass>();
        }

        public class YourNonMonoClass{
            public void YourFunction() {
                Debug.Log(GetType()+ "/YourFunction()/ Test Construction Inject To Non MonoBehaviour");
            }
        }

        public class YourClass : ITickable {
            public YourClass(YourNonMonoClass yourNonMonoClass) {
                yourNonMonoClass.YourFunction();
            }
            

            // 需要在 context 绑定擦能使用
            public void Tick()
            {
                Debug.Log(GetType() + "/Tick()/ Test ITickable ……");

            }
        }
    }

}
