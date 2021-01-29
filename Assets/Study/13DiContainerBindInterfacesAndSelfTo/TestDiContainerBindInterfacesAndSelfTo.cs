using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDiContainerBindInterfacesAndSelfTo : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var container = new DiContainer();
            container.BindInterfacesAndSelfTo<YourClass>().AsSingle();

            Debug.Log(GetType() + "/Start()/ Resolve<IYourInterface1>().GetType() = " + container.Resolve<IYourInterface1>().GetType());
            Debug.Log(GetType() + "/Start()/ Resolve<IYourInterface2>().GetType() = " + container.Resolve<IYourInterface2>().GetType());
            Debug.Log(GetType() + "/Start()/ Resolve<YourClass>().GetType() = " + container.Resolve<YourClass>().GetType());
            // 这个因该会报错
            Debug.Log(GetType() + "/Start()/ Resolve<AbsYourClass>().GetType() = " + container.Resolve<AbsYourClass>().GetType());
   
        }

        interface IYourInterface1 { }
        interface IYourInterface2 { }
        class AbsYourClass : IYourInterface1, IYourInterface2 { }
        class YourClass : AbsYourClass { }
    }
}
