using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestContainerScriptableObjectInstaller : MonoBehaviour
    {
        [Inject]
        private YourScriptableObjectInstaller.YourConfig mYourConfig { get; set; }
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(GetType()+ "/Start()/ mYourConfig.version = " + mYourConfig.version);
        }
    }
}
