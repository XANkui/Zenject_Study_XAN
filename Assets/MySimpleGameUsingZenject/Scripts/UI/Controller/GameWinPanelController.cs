using Jamjardavies.Zenject.ViewController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{

    public class GameWinPanelController : Controller<GameWinPanel>
    {
        [Inject] SignalBus mSignalBus;
        public override void Initialise()
        {
            View.Show(false);
            View.ResetButton
                .onClick.AddListener(() => {
                    View.Show(false);
                    mSignalBus.Fire<GameRestartSignal>();
                });
        }

        public override void OnDestroy()
        {
            mSignalBus = null;
        }
    }
}
