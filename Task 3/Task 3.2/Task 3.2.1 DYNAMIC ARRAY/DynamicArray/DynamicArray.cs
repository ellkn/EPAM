using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyDynamicArray
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>, ICloneable
    {
        protected T[] _dynamicArray = null;
        public int Length { get; set; } = 0;
        public int Capacity
        {
            get => _dynamicArray.Length;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("the capacity cannot be less than 0");
                }
                if (value != Capacity)
                {
                    NewCapacity(value);
                }
            }
        }
        private void NewCapacity(int newCapacity)
        {
            T[] newDynamicArray = new T[newCapacity];
            int length = (_dynamicArray.Length > newCapacity) ? newCapacity : _dynamicArray.Length;
            for (int i = 0; i < length; i++)
            {
                newDynamicArray[i] = _dynamicArray[i];
            }
            _dynamicArray = newDynamicArray;
            Capacity = _dynamicArray.Length;
        }
        public DynamicArray()
        {
            _dynamicArray = new T[8];
        }
        public DynamicArray(int capacity)
        {
            _dynamicArray = new T[capacity];
        }
        public DynamicArray(IEnumerable<T> arrayElements)
        {
            _dynamicArray = new T[arrayElements.Count()]; // Linq
            // or _dynamicArray = arrayElements.ToArray(); 
            Length = _dynamicArray.Length;
        }
        public void Add(T element)
        {
            if (Capacity == Length)
            {
                Capacity *= 2;
            }
            _dynamicArray[Length++] = element;

        }
        public void AddRange(IEnumerable<T> elements) //CHECK
        {

            if(Length + elements.Count() > Capacity)
            {
                Capacity = Length + elements.Count();
            }
            elements.ToArray().CopyTo(_dynamicArray, Length);
            Length = Length + elements.Count();
        }
        public bool Remove(int index)
        {
            if (index >= Length || index < -Length)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }
            for (int i = index; i < _dynamicArray.Length - 1; i++)
            {
                _dynamicArray[i] = _dynamicArray[i + 1];
            }
            Length--;
            //_dynamicArray.Length -= 1; //err
            return true;
        }
        public bool Insert(T value, int position)
        {
            if (position >= Length || position < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }
            if(Length == position)
            {
                _dynamicArray[position] = value;
                Length++;
                return true;
            }
            for (int i = Length; i > position ; i--)
            {
                _dynamicArray[i] = _dynamicArray[i - 1];
            }
            Length++;
            _dynamicArray[position] = value;
            return true;
        }
        public T this[int index] 
        {
            get
            {
                if (index >= Length || index < -Length)
                {
                    throw new ArgumentOutOfRangeException("Check index");
                }
                if (index > 0)
                {
                    return _dynamicArray[index];
                }
                else // index <0
                {
                    return _dynamicArray[Length + index];
                }
            }
            set
            {
                if (index >= Length || index < -Length)
                {
                    throw new ArgumentOutOfRangeException("Check index");
                }
                if (index > 0)
                {
                    _dynamicArray[index] = value;
                }
                else
                {
                    _dynamicArray[Length + index] = value;
                }
            }
        }
        public T[] ToArray()
        {
            T[] someNewArray = new T[Length];
            for (int i = 0; i < Length; i++)
            {
                someNewArray[i] = _dynamicArray[i];
            }
            return someNewArray;
        }
        public object Clone() => new DynamicArray<T>(_dynamicArray); //for me - returns a copy of the current instance of the object
        public IEnumerator GetEnumerator()
        {
            return new DynamicArrayEnumerator(_dynamicArray, Length);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new DynamicArrayEnumerator(_dynamicArray, Length);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>)GetEnumerator();
        public class DynamicArrayEnumerator : IEnumerator<T>
        {
            protected readonly T[] dynamicArray;
            protected readonly int length; 
            protected int position = -1;
            public DynamicArrayEnumerator(T[] array, int length)
            {
                dynamicArray = array;
                this.length = length;
            }

            public T Current
            {
                get
                {
                    try
                    {
                        return dynamicArray[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose() { }

            public virtual bool MoveNext()
            {
                if(position < length - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }
        }
        public void Print()
        {
            for (int i = 0; i < _dynamicArray.Length; i++)
            {
                Console.WriteLine($"[{i}] = {_dynamicArray[i]}");
            }
            Console.WriteLine($"Capacity = {Capacity}, Length = {Length}");
        }
    }
}
