using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySimpleGameUsingZenject
{
    public class Property<T>
    {
        private T mValue;
        public T Value {
            get {
                return mValue;
            }

            set {
                if (mValue.Equals(value)==false)
                {
                    mValue = value;

                    if (OnValueChangedEvent!=null)
                    {
                        OnValueChangedEvent.Invoke();
                    }
                }
            }
        }

        public event Action OnValueChangedEvent;
    }
}
