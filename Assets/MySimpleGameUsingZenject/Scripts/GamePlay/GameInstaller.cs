using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            // 注册信号
            SignalBusInstaller.Install(Container);
            Container.DeclareSignal<GameOverSignal>();
            Container.DeclareSignal<GameRestartSignal>();

            Container.Bind<GameSaveService>().AsSingle();
            // 继承了 Interface 接口 所以使用 BindInterfacesAndSelfTo
            Container.BindInterfacesAndSelfTo<GameModel>().AsSingle();
            Container.Bind<ViewModel>().AsSingle();
            
        }
    }
}