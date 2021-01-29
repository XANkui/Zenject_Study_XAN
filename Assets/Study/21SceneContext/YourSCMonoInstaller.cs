using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    public class YourSCMonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<YourClass>().AsSingle();
        }

        public class YourClass {
            public void YourFunction() {
                Debug.Log(GetType()+ "/YourFunction()/ Test Scene Context бнбн");
            }
        }
    }
}