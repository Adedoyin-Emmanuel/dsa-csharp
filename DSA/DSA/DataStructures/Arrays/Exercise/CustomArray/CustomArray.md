# Build A Custom Array

The task here is to build a custom array that automatically resize. It should
also provide methods for adding, removing and finding element at their index. This should be fun :)

**Methods**

1. Insert
2. IndexOf
3. RemoveAt
4. Count


## Exercise

1.  Extend the Array class and add a new method to return the largest
number. What is the runtime complexity of this method?
2.  Extend the Array class and add a method to return the common items
    in this array and another array.
3. Extend the Array class and add a method to reverse the array. For
   example, if the array includes [1, 2, 3, 4], after reversing and printing it,
   we should see [4, 3, 2, 1].
4. Extend the Array class and add a new method to insert an item at a
   given index:

### Solution

1. Runtime Complexity of `Array.Max()` is `O(n)`. This is because we have to
   compare each value of the array to a `temporary` max variable. In the best-case scenario,
   the highest number is the first element in the array. In the worst-case scenario, the highest
   number is the last element in the array. Irrespective of both scenarios, the loop compares each value in the array.
   Therefore the Runtime complexity is `O(n)`. Note that this is for an unsorted array. The space complexity is `O(1)`. This is 
   because the memory allocated for the highest number variable is constant irrespective of the size of the array. 