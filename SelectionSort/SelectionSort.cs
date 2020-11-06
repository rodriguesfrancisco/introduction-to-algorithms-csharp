using System;

// Exercise 2.2-2
// Consider sorting n number stored in array A by first finding the smallest
// element of A and exchanging it with the element in A[1]. The find the second
// smallest element of A, and exchange it with A[2]. Continue in this manner for
// the first n-1 elements of A. Write pseudocode for the algorithm, which is 
// known as Selection Sort.

namespace SelectionSort
{
	class SelectionSort
	{
		static void Main(string[] args)
		{
			int[] unsortedArray = new int[] { 5, 2, 4, 6, 1, 3, 12, 123, 65, 7, 24 };
			var sortedArray = SelectionSortMethod(unsortedArray);
			foreach (var item in sortedArray)
			{
				Console.Write(item + ",");
			}
		}

		static int[] SelectionSortMethod(int[] array)
		{
			for(int i = 0; i < array.Length; i++)
			{
				int smallestElementIndex = i;
				for(int j = i + 1; j < array.Length; j++)
				{
					if(array[j] < array[smallestElementIndex])
					{
						smallestElementIndex = j;
					}
				}
				int temp = array[i];
				array[i] = array[smallestElementIndex];
				array[smallestElementIndex] = temp;
			}
			return array;
		}
	}
}
