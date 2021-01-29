using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDynamicInject : MonoBehaviour
    {
        [Inject]
        void YourInjectFunc(YourDynamicInjectInstaller.YourClass yourClass) {
            yourClass.YourFunction();
        }
       
    }
}
