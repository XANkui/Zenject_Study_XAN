using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MySimpleGameUsingZenject
{
    public class EnemyController : MonoBehaviour
    {
        [Inject] private Setting mSetting;
        [Inject] DiContainer mContainer;
        private Vector3 mInitPos;
        private bool isEnableMoving = true;
        private void Awake()
        {
            mContainer.BindInstance(this);
            mInitPos = transform.localPosition;
        }

        // Update is called once per frame
        void Update()
        {
            if (isEnableMoving)
            {
                transform.Translate(-1 * mSetting.SpeedScale, 0, 0);

            }
        }

        [System.Serializable]
        public class Setting {
            public int SpeedScale=1;
        }

        public void ResetToInitPos()
        {
            transform.localPosition = mInitPos;
        }

        public void ReStart() {
            ResetToInitPos();
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
