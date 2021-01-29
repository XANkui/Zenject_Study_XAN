using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDiContainerBindAsCached : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // 申请DiContainer，绑定类，每种约束类型 cached （cached 同种 约束类型 解析获取同一个单例；不同种类型，不同单例）
            // 注意如果是 Bind(typeof(),...)一起绑定，则是一个单例
            TestBind();
            TestBindTypeof();
        }

        // 申请DiContainer，绑定类，每种约束类型 cached （cached 同种 约束类型 解析获取同一个单例；不同种类型，不同单例）
        void TestBind() {
            var container = new DiContainer();
            container.Bind<IYourInterface>().To<YourClass>().AsCached();
            container.Bind<AbsYourClass>().To<YourClass>().AsCached();
            container.Bind<YourClass>().To<YourClass>().AsCached();

            // 两次解析获取指定类，看哈希值是否一致，同种 约束类型 解析获取同一个单例；不同种类型，不同单例
            Debug.Log(GetType() + "/Start()/ First IYourInterface container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<IYourInterface>().GetHashCode());
            Debug.Log(GetType() + "/Start()/ Second IYourInterface container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<IYourInterface>().GetHashCode());

            Debug.Log(GetType() + "/Start()/ First AbsYourClass container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<AbsYourClass>().GetHashCode());
            Debug.Log(GetType() + "/Start()/ Second AbsYourClass container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<AbsYourClass>().GetHashCode());

            Debug.Log(GetType() + "/Start()/ First YourClass container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<YourClass>().GetHashCode());
            Debug.Log(GetType() + "/Start()/ Second YourClass container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<YourClass>().GetHashCode());
        }

        // 注意如果是 Bind(typeof(),...)一起绑定，则是一个单例
        void TestBindTypeof()
        {
            var container = new DiContainer();
            container.Bind(typeof(IYourInterface),
                typeof(AbsYourClass), 
                typeof(YourClass)).To<YourClass>().AsCached();

            // 两次解析获取指定类，看哈希值是否一致，注意如果是 Bind(typeof(),...)一起绑定，则是一个单例
            Debug.Log(GetType() + "/Start()/ First Typeof IYourInterface container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<IYourInterface>().GetHashCode());
            Debug.Log(GetType() + "/Start()/ Second Typeof IYourInterface container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<IYourInterface>().GetHashCode());

            Debug.Log(GetType() + "/Start()/ First Typeof AbsYourClass container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<AbsYourClass>().GetHashCode());
            Debug.Log(GetType() + "/Start()/ Second Typeof AbsYourClass container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<AbsYourClass>().GetHashCode());

            Debug.Log(GetType() + "/Start()/ First Typeof YourClass container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<YourClass>().GetHashCode());
            Debug.Log(GetType() + "/Start()/ Second Typeof YourClass container.Resolve<YourClass>().GetHashCode() = " + container.Resolve<YourClass>().GetHashCode());
        }


        interface IYourInterface { }
        class AbsYourClass : IYourInterface { }
        class YourClass : AbsYourClass { }
    }
}
