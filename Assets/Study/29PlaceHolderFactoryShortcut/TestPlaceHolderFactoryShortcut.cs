using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Study
{
    public class TestPlaceHolderFactoryShortcut : MonoBehaviour
    {
        public Monster MonsterPrefab;

        // Start is called before the first frame update
        void Start()
        {
            var container = new DiContainer();

            container.BindFactory<Monster, Monster.YourFactory>()
                .FromComponentInNewPrefab(MonsterPrefab)
                .WithGameObjectName("Monster")
                .UnderTransformGroup("MonstersGroup");

            var factory =  container.Resolve<Monster.YourFactory>();

            factory.Create().YourFunction();
            factory.Create().YourFunction();

        }

        
    }
}
