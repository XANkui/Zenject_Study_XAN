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



            #region 添加UIManager 使用 ViewCOntroller 自动绑定


            //// 动态加载预制体
            //Container.Bind<GameInfoPanel>().FromComponentInNewPrefabResource("Prefabs/UIPanel/GameInfoPanel")
            //    .UnderTransform(ctx=>ctx.Container.ResolveId<RectTransform>("UIRoot"))
            //    .AsSingle().Lazy();
            //Container.Bind<GameOverPanel>().FromComponentInNewPrefabResource("Prefabs/UIPanel/GameOverPanel")
            //    .UnderTransform(ctx => ctx.Container.ResolveId<RectTransform>("UIRoot"))
            //    .AsSingle().Lazy(); 
            //Container.Bind<GameWinPanel>().FromComponentInNewPrefabResource("Prefabs/UIPanel/GameWinPanel")
            //    .UnderTransform(ctx => ctx.Container.ResolveId<RectTransform>("UIRoot"))
            //    .AsSingle().Lazy(); 

            //// View Controller
            //Container.BindController<GameInfoPanelController>();
            //Container.BindController<GameOverPanelController>();
            //Container.BindController<GameWinPanelController>();

            #endregion


            Container.Bind<UIManager>().AsSingle();

            // 重新绑定，方便测试（依赖倒置原则（对抽象进行编程））
            Container.Rebind<IGameSaveService>().To<SimulationSaveService>().AsSingle();
        }
    }
}