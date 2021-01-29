using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDiContainerBindFromFactory : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var container = new DiContainer();
            container.Bind<int>().FromFactory<YourFactoryClass>();

            Debug.Log(GetType() + "/Start()/ container.Resolve<int>() = " + container.Resolve<int>());
            Debug.Log(GetType() + "/Start()/ container.Resolve<int>() = " + container.Resolve<int>());
        }

        class YourFactoryClass : IFactory<int> {
            public int Create()
            {
                return Random.Range(0,100);
            }
        }
    }
}
