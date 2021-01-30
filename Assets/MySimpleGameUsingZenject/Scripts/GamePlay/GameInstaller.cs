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

            Container.Bind<IGameSaveService>().To<GameSaveService>().AsSingle();
            // 继承了 Interface 接口 所以使用 BindInterfacesAndSelfTo
            Container.BindInterfacesAndSelfTo<GameModel>().AsSingle();
            Container.Bind<ViewModel>().AsSingle();

            // View Controller
            Container.BindController<GameInfoPanelController>();
            Container.BindController<GameOverPanelController>();
            Container.BindController<GameWinPanelController>();

            // 重新绑定，方便测试（依赖倒置原则（对抽象进行编程））
            Container.Rebind<IGameSaveService>().To<SimulationSaveService>().AsSingle();
        }
    }
}