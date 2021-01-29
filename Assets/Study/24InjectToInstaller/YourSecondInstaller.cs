using UnityEngine;
using Zenject;

namespace Zenject.Study
{
    public class YourSecondInstaller : MonoInstaller
    {
        // 在 installer 中进行注入
        [Inject] private string mStr { get; set; }
        public override void InstallBindings()
        {
            Debug.Log(GetType()+ "/InstallBindings()/ mStr = " + mStr);
        }

        private void Start()
        {
            Debug.Log(GetType() + "/Start()/ mStr = " + mStr);
        }
    }
}