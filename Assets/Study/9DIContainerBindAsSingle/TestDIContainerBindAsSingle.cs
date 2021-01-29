using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDIContainerBindAsSingle : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // 申请DiContainer，绑定类，作为单例
            var container = new DiContainer();
            container.Bind<YourClass>().AsSingle();

            // 两次解析获取指定类，看哈希值是否一致，单例一致
            Debug.Log(GetType()+ "/Start()/ First container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<YourClass>().GetHashCode());
            Debug.Log(GetType()+ "/Start()/ Second container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<YourClass>().GetHashCode());
        }

        public class YourClass { }
    }
}
