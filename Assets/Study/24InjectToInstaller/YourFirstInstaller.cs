using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    public class YourFirstInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInstance("Test Inject to Installer¡­¡­");
        }
    }
}