using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    public class TestBindExcuteOrderInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<YourClass1>().AsSingle();
            Container.BindInterfacesAndSelfTo<YourClass2>().AsSingle();

            // BindExecutionOrder<T>(num) num 越小越先执行
            Container.BindExecutionOrder<YourClass1>(-10);
            Container.BindExecutionOrder<YourClass2>(-30);
        }

        public class YourClass1 : IInitializable {
            public void Initialize()
            {
                Debug.Log(GetType() + "/Initialize()/ Test Bind Excute Order ……");
            }
        }

        public class YourClass2 : IInitializable
        {
            public void Initialize()
            {
                Debug.Log(GetType() + "/Initialize()/ Test Bind Excute Order ……");
            }
        }
    }
}