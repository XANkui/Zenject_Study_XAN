using Jamjardavies.Zenject.ViewController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class UIManager 
    {
        [Inject] DiContainer mContainer;

        public TController OpenPanel<TController>() where TController : Controller {
            var panel = mContainer.TryResolve<TController>();

            if (panel != null)
            {
                return panel as TController;
            }

            return LoadPanel<TController>();
        }

        TController LoadPanel<TController>() where TController : Controller {
            mContainer.Bind<TController>()
                    .AsCached();

            var retController = mContainer.Resolve<TController>();
            retController.Initialise();
            return retController;
        }

        public void ClosePanel<TController>() where TController : Controller
        {
            mContainer.Resolve<TController>().Dispose();
            mContainer.Unbind<TController>();
        }
    }
}
