using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDiContainerBindInstanceClass : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var container = new DiContainer();
            container.Bind<YourClass1>().FromInstance(new YourClass1());
            container.BindInstance(new YourClass2());
            container.BindInstances(new YourClass3(), new YourClass4(),new YourClass5());

            Debug.Log(GetType() + "/Start()/ Resolve<YourClass1>().GetType() = " + container.Resolve<YourClass1>().GetHashCode());
            Debug.Log(GetType() + "/Start()/ Resolve<YourClass1>().GetType() = " + container.Resolve<YourClass1>().GetHashCode());
            Debug.Log(GetType() + "/Start()/ Resolve<YourClass2>().GetType() = " + container.Resolve<YourClass2>().GetHashCode());
            Debug.Log(GetType() + "/Start()/ Resolve<YourClass3>().GetType() = " + container.Resolve<YourClass3>().GetHashCode());
            Debug.Log(GetType() + "/Start()/ Resolve<YourClass4>().GetType() = " + container.Resolve<YourClass4>().GetHashCode());
            Debug.Log(GetType() + "/Start()/ Resolve<YourClass5>().GetType() = " + container.Resolve<YourClass5>().GetHashCode());
        }

        class YourClass1 { }
        class YourClass2 { }
        class YourClass3 { }
        class YourClass4 { }
        class YourClass5 { }
    }
}
