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

            Container.Bind<GameModel>().AsSingle();
        }
    }
}