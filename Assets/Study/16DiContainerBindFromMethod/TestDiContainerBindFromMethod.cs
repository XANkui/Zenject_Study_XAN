using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Zenject.Study
{
    public class TestDiContainerBindFromMethod : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var container = new DiContainer();
            container.Bind<int>().FromMethod(GetARandomNumber);
            container.Bind<string>().FromMethod(()=> "Bind From Method ");

            Debug.Log(GetType() + "/Start()/ container.Resolve<int>() = " + container.Resolve<int>());
            Debug.Log(GetType() + "/Start()/ container.Resolve<int>() = " + container.Resolve<int>());
            Debug.Log(GetType() + "/Start()/ container.Resolve<string>() = " + container.Resolve<string>());
            Debug.Log(GetType() + "/Start()/ container.Resolve<string>() = " + container.Resolve<string>());
        }

        int GetARandomNumber() {
            return Random.Range(1,100);
        }
    }
}
