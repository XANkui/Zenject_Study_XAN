using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    public class PropertyInjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<YourClass>().AsSingle();
        }


        public class YourClass {

            public void YourFunction()
            {
                Debug.Log(GetType() + "/YourFunction()/ Property Inject Test бнбн");

            }
        }
    }
}