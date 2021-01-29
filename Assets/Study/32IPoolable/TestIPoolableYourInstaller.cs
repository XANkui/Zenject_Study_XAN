using UnityEngine;
using Zenject;

namespace Zenject.Study
{

    public class TestIPoolableYourInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindFactory<YourClass, YourClass.YourFactory>()
                .FromPoolableMemoryPool(x=>x.WithInitialSize(2));
        }

        private void Start()
        {
            var factory = Container.Resolve<YourClass.YourFactory>();
            var temp =  factory.Create();
            temp.LateDispose();
            factory.Create();
            factory.Create();
            factory.Create();
        }

        public class YourClass : IPoolable<IMemoryPool>, ILateDisposable
        {
            
            public void OnDespawned()
            {
                Debug.Log(GetType() + "/OnDespawned()/ Test IPoolable");

            }

            public void OnSpawned(IMemoryPool p1)
            {
                Debug.Log(GetType() + "/OnSpawned()/ Test IPoolable");

            }

            public void LateDispose()
            {
                Debug.Log(GetType() + "/LateDispose()/ Test IPoolable");
                OnDespawned();
            }

            public class YourFactory : PlaceholderFactory<YourClass> { }
        }
    }
}
