using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class WinWallTrigger : MonoBehaviour
    {
        [Inject] SignalBus mSignalBus;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name == "Enemy")
            {
                Debug.Log(GetType() + "/OnTriggerEnter2D()/ Game Win ……");

                // 注入的方法
                // 发射信号
                mSignalBus.Fire(new GameOverSignal()
                {
                    IsWin = true
                });

            }
        }
    }
}
