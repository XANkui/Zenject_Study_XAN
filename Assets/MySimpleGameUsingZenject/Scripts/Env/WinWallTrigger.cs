using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class WinWallTrigger : MonoBehaviour
    {
        [Inject] DiContainer mContainer;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name == "Enemy")
            {
                Debug.Log(GetType() + "/OnTriggerEnter2D()/ Game Win ……");                

                // 注入的方法
                mContainer.Resolve<GameWinPanel>().Show(true);
                mContainer.Resolve<EnemyController>().StopMoving();
                mContainer.Resolve<PlayerController>().StopMoving();
            }
        }
    }
}
