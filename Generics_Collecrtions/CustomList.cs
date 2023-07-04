using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Collections
{
    public class CustomList<T> : IEnumerable<T>
    {
        private T[] _array = new T[0];
        private int _count;
        private int _capacity;
        private T[] _temp;

        public CustomList(int capacity = 4)
        {
            this._capacity = capacity;
            this._array = new T[capacity];
            this._count = 0;
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return _array.Length == 0;
            }
        }

        public T this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        public void Resize()
        {
            _temp = _array;
            _capacity *= 2;
            _array = new T[_capacity];

            for (int i = 0; i < _temp.Length; i++)
            {
                _array[i] = _temp[i];
            }
        }

        public void Add(T item)
        {
            if (_capacity == _count)
                Resize();

            _array[_count] = item;

            _count++;

        }

        public void Clear()
        {
            _count = 0;
            _array = new T[0];
        }

        public void InsertAt(int index, T item)
        {
            if (_capacity == _count) Resize();

            for (int i = _count; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = item;
            _count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
