using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySimpleGameUsingZenject
{
    public class GameModel
    {
        #region PlayerPos
        private Vector3 mPlayerPos;

        public Vector3 PlayerPos
        {
            get
            {
                return mPlayerPos;
            }
            set
            {
                if (mPlayerPos != value)
                {
                    mPlayerPos = value;
                    if (OnPlayerPosChanged!=null)
                    {
                        OnPlayerPosChanged.Invoke();
                    }
                }

            }
        }

        public event Action OnPlayerPosChanged;
        #endregion

        #region NPC Pos
        private Vector3 mNPCPos;

        public Vector3 NPCPos
        {
            get
            {
                return mNPCPos;
            }
            set
            {
                if (mNPCPos != value)
                {
                    mNPCPos = value;
                    if (OnNPCPosChanged != null)
                    {
                        OnNPCPosChanged.Invoke();
                    }
                }

            }
        }

        public event Action OnNPCPosChanged;
        #endregion
    }
}
