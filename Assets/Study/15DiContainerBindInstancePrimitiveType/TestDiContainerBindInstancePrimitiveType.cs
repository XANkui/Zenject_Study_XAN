using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDiContainerBindInstancePrimitiveType : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var container = new DiContainer();
            container.Bind<int>().FromInstance(520);
            container.BindInstance("Bind Instance Primitive Type");

            Debug.Log(GetType()+ "/Start()/ container.Resolve<int>() = " + container.Resolve<int>());
            Debug.Log(GetType()+ "/Start()/ container.Resolve<string>() = " + container.Resolve<string>());
        }

        
    }
}
