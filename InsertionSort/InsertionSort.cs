using System;

namespace InsertionSort
{
	class InsertionSort
	{
		static void Main(string[] args)
		{
			int[] unsortedArray = new int[] { 5, 2, 4, 6, 1, 3, 12, 123, 65, 7, 24 };
			
			var nonDecreasingSortedArray = NonDecreasingInsertionSort(unsortedArray);

			Console.WriteLine("Printing non decreasing sorted array");
			foreach (var item in nonDecreasingSortedArray)
			{
				Console.Write(item + ",");
			}
			Console.WriteLine();

			var nonIncreasingSortedArray = NonIncreasingInsertionSort(unsortedArray);
			Console.WriteLine("Printing non increasing sorted array");
			foreach (var item in nonIncreasingSortedArray)
			{
				Console.Write(item + ",");
			}
			Console.WriteLine();
		}

		static int[] NonDecreasingInsertionSort(int[] array)
		{
			for (var j = 1; j < array.Length; j++)
			{
				int key = array[j];
				int i = j - 1;
				while (i >= 0 && array[i] > key)
				{
					array[i + 1] = array[i];
					i = i - 1;
				}
				array[i + 1] = key;
			}
			return array;
		}

		// Exercise 2.1-2
		// Rewrite the INSERTION-SORT procedure to sort into nonincreasing 
		// instead of nondecreasing order
		static int[] NonIncreasingInsertionSort(int[] array)
		{
			for (var j = 1; j < array.Length; j++)
			{
				int key = array[j];
				int i = j - 1;
				while (i >= 0 && array[i] < key)
				{
					array[i + 1] = array[i];
					i = i - 1;
				}
				array[i + 1] = key;
			}
			return array;
		}
	}
}
