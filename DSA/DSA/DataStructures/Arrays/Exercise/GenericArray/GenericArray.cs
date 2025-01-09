namespace DSA.DSA.DataStructures.Arrays.Exercise.GenericArray;

public class GenericArray<T>
{
    /*
     * Insert
     * IndexOf
     * RemoveAt
     * Count
     * Print
     */

    private int _size;
    private int _capacity;
    private T[] _items;

    public GenericArray()
    {
        _size = 0;
        _capacity = 5;
        _items = new T[5];
    }

    public void Insert(T element)
    {
        if (_size > _capacity)
        {
            _capacity *= 2;
            
            var newArray = new T[_capacity];

            for (int i = 0; i < _size; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;
        }
        
        _items[_size] = element;
        _size++;
    }

    public int IndexOf(T element)
    {
        for (int i = 0; i < _size; i++)
        {
            if (_items[i]!.Equals(element))
            {
                return i;
            }
        }

        return -1;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index > _size - 1)
        {
            throw new ArgumentOutOfRangeException("Invalid index!");
        }
        
        //swap items in array starting from parameter index
        for (int i = index; i < _size - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _items[_size - 1] = default!;
        _size--;
    }


    public int Count()
    {
        return _size;
    }

    public void Print()
    {
        for (int i = 0; i < _size; i++)
        {
            Console.WriteLine(_items[i]);
        }
    }
}