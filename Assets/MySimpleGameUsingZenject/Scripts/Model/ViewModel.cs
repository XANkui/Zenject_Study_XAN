using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySimpleGameUsingZenject
{
    public class ViewModel
    {
        #region PlayerPos
        public Property<Vector3> PlayerPos = new Property<Vector3>();
        #endregion

        #region NPC Pos
        public Property<Vector3> NPCPos = new Property<Vector3>();
        #endregion
    }
}
