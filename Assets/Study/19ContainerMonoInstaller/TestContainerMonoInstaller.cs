using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestContainerMonoInstaller : MonoBehaviour
    {
        [Inject]
        private YourMonoInstaller.YourClass YourClass { get; set; }

        // Start is called before the first frame update
        void Start()
        {
            YourClass.YourFunction();
        }

        
    }
}
