using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MyDynamicArray;

namespace MyCycledDynamicArray
{
    public class CycledDynamicArray<T> : DynamicArray<T>
    {
        public new IEnumerator<T> GetEnumerator()
        {
            return new CycledDynamicEnumerator(_dynamicArray, Length);
        }
        class CycledDynamicEnumerator : DynamicArrayEnumerator
        {
            public CycledDynamicEnumerator(T[] array, int length) : base(array, length) { }

            public override bool MoveNext()
            {
                if (position >= length - 1)
                {
                    position = -1;
                    //Reset();
                }
                position++;
                return true;
            }
        }
    }
}
//or we can repeat the DynamicArray code completely,
//slightly changing the necessary parameters,
//but then the code repeats, which is very bad...

// and is it possible to implement this at all, or is it better to copy it anyway?