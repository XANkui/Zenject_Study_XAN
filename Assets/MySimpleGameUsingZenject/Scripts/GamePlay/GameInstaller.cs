using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            // ע���ź�
            SignalBusInstaller.Install(Container);
            Container.DeclareSignal<GameOverSignal>();
            Container.DeclareSignal<GameRestartSignal>();

            Container.Bind<IGameSaveService>().To<GameSaveService>().AsSingle();
            // �̳��� Interface �ӿ� ����ʹ�� BindInterfacesAndSelfTo
            Container.BindInterfacesAndSelfTo<GameModel>().AsSingle();
            Container.Bind<ViewModel>().AsSingle();

            // ��̬����Ԥ����
            Container.Bind<GameInfoPanel>().FromComponentInNewPrefabResource("Prefabs/UIPanel/GameInfoPanel")
                .UnderTransform(ctx=>ctx.Container.ResolveId<RectTransform>("UIRoot"))
                .AsSingle().Lazy();
            Container.Bind<GameOverPanel>().FromComponentInNewPrefabResource("Prefabs/UIPanel/GameOverPanel")
                .UnderTransform(ctx => ctx.Container.ResolveId<RectTransform>("UIRoot"))
                .AsSingle().Lazy(); 
            Container.Bind<GameWinPanel>().FromComponentInNewPrefabResource("Prefabs/UIPanel/GameWinPanel")
                .UnderTransform(ctx => ctx.Container.ResolveId<RectTransform>("UIRoot"))
                .AsSingle().Lazy(); 

            // View Controller
            Container.BindController<GameInfoPanelController>();
            Container.BindController<GameOverPanelController>();
            Container.BindController<GameWinPanelController>();

            // ���°󶨣�������ԣ���������ԭ�򣨶Գ�����б�̣���
            Container.Rebind<IGameSaveService>().To<SimulationSaveService>().AsSingle();
        }
    }
}