using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    public class TestInstallerSignal : MonoInstaller
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);

            Container.DeclareSignal<YourSignalClass>();
            Container.BindSignal<YourSignalClass>().ToMethod((yourSignalClass)=> {
                Debug.Log(GetType()+ "/BindSignal()/ value =" + yourSignalClass.YourRandomFunction());

            });
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                var signalBus = Container.Resolve<SignalBus>();
                signalBus.Fire(new YourSignalClass());
            }
        }

        public class YourSignalClass {
            public int YourRandomFunction() {
                return Random.Range(0,100);
            }
        }
    }
}