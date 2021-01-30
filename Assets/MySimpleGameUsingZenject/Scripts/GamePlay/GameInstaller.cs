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

            // View Controller
            Container.BindController<GameInfoPanelController>();
            Container.BindController<GameOverPanelController>();
            Container.BindController<GameWinPanelController>();

            // ���°󶨣�������ԣ���������ԭ�򣨶Գ�����б�̣���
            Container.Rebind<IGameSaveService>().To<SimulationSaveService>().AsSingle();
        }
    }
}