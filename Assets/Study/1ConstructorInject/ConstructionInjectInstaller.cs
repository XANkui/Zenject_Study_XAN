using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    public class ConstructionInjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<YourClass>().AsSingle();
        }

        public class YourClass
        {
            public void YourFunction() {
                Debug.Log(GetType() + "/YourFunction()/ Constructor Inject Test бнбн");

            }
        }
    }
}