using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    public class TestOtherInterfaceYourInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<YourOtherInterfaceClass>().AsSingle();
        }

        public class YourOtherInterfaceClass : ITickable, IFixedTickable, IInitializable, ILateDisposable {
            public void Tick()
            {
                Debug.Log(GetType() + "/Tick()/ Test ITickable бнбн");
            }

            public void FixedTick()
            {
                Debug.Log(GetType() + "/FixedTick()/ Test IFixedTickable бнбн");
            }

            public void Initialize()
            {
                Debug.Log(GetType() + "/Initialize()/ Test IInitializable бнбн");
            }

            public void LateDispose()
            {
                Debug.Log(GetType() + "/LateDispose()/ Test ILateDisposable бнбн");
            }
        }
    }
}