namespace DSA.DSA.DataStructures.Arrays.Exercise.CustomArray;

/*
 * You might see a lot of comment here and think the code was written by AI
 * Please don't think so. It wouldn't make any sense for someone to want to get
 * Better at DSA and Design patterns and still use AI to do his / her practise assignment.
 *
 *
 * Writing Comment before attempting the question makes you understand what you are about to do.
 * Think of it as writing pseudocode or white boarding. You explain it in English and then
 * convert it to code. 
 */
public class CustomArray
{
    /*
     * Insert
     * IndexOf
     * RemoveAt
     * Count
     * Print
     */
    
    /*
     * Insert: Takes an <int> value to insert
     */

    private int _size;
    private int[] _items;
    private int _capacity;


    public CustomArray()
    {
        _size = 0;
        _items = [5];
        _capacity = 5;
    }
    
    

    public void Insert(int value)
    {
        /*
         * Check if size of the array is more than the capacity
         */

        if (_size >= _capacity)
        {
            _capacity *= 2;
        }

        _items[_size] = value;

        _size++;
    }

    public int IndexOf(int element)
    {
        const int defaultValue = -1;

        for (int i = 0; i < _size; i++)
        {
            if (_items[i] == element)
            {
                return i;
            }
        }

        return defaultValue;
    }


    public void RemoveAt(int index)
    {
        /*
         * Check if the input index is valid
         * Input index must be > 0 < size - 1
         */

        if (index < 0 || index > _size - 1)
        {
            throw new Exception("Invalid index!");
        }
        
        /*
         * Swap values
         */

        for (int i = index; i < _size - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _size--;
    }


    public int Count()
    {
        return _size;
    }

    /*
     * Yes I know the print method is not meant to be here according to Software Design Principles
     * But spare me my lord. Just for the sake of practise. 
     */
    public void Print()
    {
        foreach (int item in _items)
        {
            Console.WriteLine(item);
        }
    }
}