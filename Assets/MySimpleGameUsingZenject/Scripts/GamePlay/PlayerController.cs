using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class PlayerController : MonoBehaviour
    {
        [Inject] private Setting mSetting { get; set; }
        [Inject] DiContainer mContainer;

        Rigidbody2D mRigidbody2D;
        private bool isEnableMoving = true;
        private void Awake()
        {
            mContainer.BindInstance(this);
        }

        private void Start()
        {
            mRigidbody2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (isEnableMoving)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    mRigidbody2D.velocity = Vector2.up * mSetting.JumpVelocityScale;
                    mRigidbody2D.AddForce(Vector2.up * mSetting.ForceScale);
                }
            }
            
        }

        [System.Serializable]
        public class Setting {
            public int JumpVelocityScale = 10;
            public int ForceScale = 10;
        }


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name == "Enemy")
            {
                Debug.Log(GetType()+ "/OnTriggerEnter2D()/ Game Over ……");

                // 老的方法
                // transform.parent.Find("GameOverPanel").gameObject.SetActive(true);

                // 注入的方法
                mContainer.Resolve<GameController>().OnGameOve(false);
                mContainer.Resolve<EnemyController>().StopMoving();
                StopMoving();
            }
        }

        public void ReStart()
        {
            StartMoving();
        }

        public void StartMoving()
        {
            isEnableMoving = true;
        }

        public void StopMoving()
        {
            isEnableMoving = false;
        }
    }
}
