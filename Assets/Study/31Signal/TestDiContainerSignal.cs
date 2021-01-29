using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestDiContainerSignal : MonoBehaviour
    {
        private DiContainer mContainer;
        private SignalBus mSignalBus;
        // Start is called before the first frame update
        void Start()
        {
            mContainer = new DiContainer();
            SignalBusInstaller.Install(mContainer);

            mContainer.DeclareSignal<int>();
            mSignalBus = mContainer.Resolve<SignalBus>();

            mSignalBus.Subscribe<int>(value=> {
                Debug.Log(GetType()+ "/Subscribe()/ value =" + value);
            });
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                mSignalBus.Fire(Random.Range(0,100));
            }
        }
    }
}