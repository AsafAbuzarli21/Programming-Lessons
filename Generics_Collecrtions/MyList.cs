namespace Generics_Collections
{
    public class MyList<T>
    {
        T[] _array = new T[0];

        T[] _tempArray;

        public int Count
        {
            get
            {
                return _array.Length;
            }
        }

        public int Capacity
        {
            get
            {
                return _array.Length;
            }
        }

        public void Add(T item)
        {
            _tempArray = _array;

            _array = new T[_tempArray.Length + 1];

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public void Show()
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class CustomList2<T>
    {
        T[] _array = new T[0];

        private int _capacity;
        private int _count = 0;

        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return _count == 0;
            }
        }

        public CustomList2(int capacity = 4)
        {
            this._capacity = capacity;
            this._array = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                return (T)_array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        private void DecreaseSize()
        {
            T[] newArray = new T[_capacity * 2];

            for (int i = 0; i < _capacity; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
            _capacity *= 2;
        }

        public void Add(T item)
        {
            if (_count == _capacity)
            {
                DecreaseSize();
            }

            _array[_count] = item;
            _count++;
        }

        public void Clear()
        {
            _count = 0;
            _array = new T[0];
        }

        public void InsertAt(T item, int index)
        {
            if (_count == _capacity)
                DecreaseSize();

            for (int i = _count; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = item;
            _count++;
        }

        public void RemoveAt(int index)
        {

        }
    }
}
