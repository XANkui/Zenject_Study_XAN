using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDiContainerBindInterfacesTo : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var container = new DiContainer();
            container.BindInterfacesTo<YourClass>().AsSingle();

            Debug.Log(GetType()+ "/Start()/ Resolve<IYourInterface1>().GetType() = " + container.Resolve<IYourInterface1>().GetType());
            Debug.Log(GetType()+ "/Start()/ Resolve<IYourInterface2>().GetType() = " + container.Resolve<IYourInterface2>().GetType());
            // 这个因该会报错
            Debug.Log(GetType()+ "/Start()/ Resolve<AbsYourClass>().GetType() = " + container.Resolve<AbsYourClass>().GetType());
        }

        interface IYourInterface1 { }
        interface IYourInterface2 { }
        class AbsYourClass : IYourInterface1, IYourInterface2{ }
        class YourClass : AbsYourClass { }
    }
}
