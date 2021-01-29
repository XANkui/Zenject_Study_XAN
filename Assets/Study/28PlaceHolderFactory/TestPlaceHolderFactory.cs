using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestPlaceHolderFactory : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var container = new DiContainer();
            container.BindInstance("Test PlaceHolder Factory……");
            container.BindFactory<YourClass, YourFactory>();

            Debug.Log(GetType()+ "/Start()/ container.Resolve<YourFactory>().Create().mStr =  " + container.Resolve<YourFactory>().Create().mStr);
        }

        public class YourClass { 
            [Inject]public string mStr { get; set; }
        }

        public class YourFactory : PlaceholderFactory<YourClass> { }
    }
}
