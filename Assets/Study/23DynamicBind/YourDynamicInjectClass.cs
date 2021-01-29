using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class YourDynamicInjectClass : MonoBehaviour
    {
        [Inject]
        void YourInjectFunc(YourDynamicBindClass yourDynamicBindClass) {
            yourDynamicBindClass.YourFunction();


        }
    }
}
