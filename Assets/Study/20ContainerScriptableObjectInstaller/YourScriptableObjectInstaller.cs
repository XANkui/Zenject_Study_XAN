using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    [CreateAssetMenu(fileName = "YourScriptableObjectInstaller", menuName = "Installers/YourScriptableObjectInstaller")]
    public class YourScriptableObjectInstaller : ScriptableObjectInstaller<YourScriptableObjectInstaller>
    {
        public YourConfig mYourConfig;

        public override void InstallBindings()
        {
            Container.BindInstance(mYourConfig);
        }

        [System.Serializable]
        public class YourConfig
        {

            public string version = "1.0.1";
        }
    }
}