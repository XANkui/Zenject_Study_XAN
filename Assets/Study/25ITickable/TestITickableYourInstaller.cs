using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    public class TestITickableYourInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ITickable>().To<YourTickableClass>().AsSingle();
        }
    }

    // Binding to ITickable  will result in Tick()  being called like Update() .
    class YourTickableClass : ITickable {
        public void Tick()
        {
            Debug.Log(GetType()+ "/Tick()/ Test ITickable бнбн");
        }
    }
}