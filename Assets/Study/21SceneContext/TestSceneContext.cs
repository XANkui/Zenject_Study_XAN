using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestSceneContext : MonoBehaviour
    {

        [Inject]
        void Injected(YourSCMonoInstaller.YourClass yourClass) {
            yourClass.YourFunction();
        }

        private void Start()
        {
                Debug.Log(GetType()+ "/Start()/ ……");

        }
    }
}
