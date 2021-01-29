using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    public class QuickStartInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<HelloZenject>()
                .AsSingle();
        }


        public class HelloZenject {
            public void Hello() {

                Debug.Log(GetType()+ "/Hello()/ Hell0o Zenject¡­¡­");
            }
        }
    }
}
