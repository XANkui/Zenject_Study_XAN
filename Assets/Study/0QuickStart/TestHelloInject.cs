using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestHelloInject : MonoBehaviour
    {
        // 注入刚才的类
        [Inject] private QuickStartInstaller.HelloZenject mHelloZenject;

        // Start is called before the first frame update
        void Start()
        {
            // 执行注入类的方法
            mHelloZenject.Hello();
        }

        
    }
}
