using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDiContainerInstaller : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var container = new DiContainer();
            YourInstallerClass.Install(container);

            container.Resolve<YourClass>().YourFunction();
        }

        class YourInstallerClass : Installer<YourInstallerClass> {
            public override void InstallBindings()
            {
                Container.Bind<YourClass>().AsSingle();
            }
        }

        class YourClass {
            public void YourFunction() {
                Debug.Log(GetType()+ "/YourFunction()/ Test DiContainer Installer ");
            }
        }
    }
}
