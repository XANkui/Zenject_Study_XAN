using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    public class ConditionBindingYourInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {

            Container.BindInstance("Test mStr¡­¡­");
            Container.BindInstance("Test Condition Binding ¡­¡­")
                .WhenInjectedInto<ConditionBindingClass>();
        }
    }
}