using System;

namespace InsertionSort
{
	class InsertionSort
	{
		static void Main(string[] args)
		{
			int[] unsortedArray1 = new int[] { 5, 2, 4, 6, 1, 3, 12, 123, 65, 7, 24 };
			int[] unsortedArray2 = new int[] { 5, 2, 4, 6, 1, 3, 12, 123, 65, 7, 24 };
			int[] unsortedArray3 = new int[] { 5, 2, 4, 6, 1, 3, 12, 123, 65, 7, 24 };
			
			var nonDecreasingSortedArray = NonDecreasingInsertionSort(unsortedArray1);

			Console.WriteLine("Printing non decreasing sorted array");
			PrintArray(nonDecreasingSortedArray);
			Console.WriteLine();

			var nonIncreasingSortedArray = NonIncreasingInsertionSort(unsortedArray2);
			Console.WriteLine("Printing non increasing sorted array");
			PrintArray(nonIncreasingSortedArray);			
			Console.WriteLine();

			Console.Write("Unsorted array: ");
			PrintArray(unsortedArray3);
			Console.WriteLine();
			Console.WriteLine("Type a value to search in the unsorted array: ");
			int valueToSearch = int.Parse(Console.ReadLine());
			int? valueIndex = LinearSearch(unsortedArray3, valueToSearch);
			if(valueIndex.HasValue)
			{
				Console.WriteLine("Value " + unsortedArray3[(int)valueIndex] + " found in the array in the index: " + valueIndex);
			} else
			{
				Console.WriteLine("Value not found");
			}
		}

		static void PrintArray(int[] array)
		{
			foreach (var item in array)
			{
				Console.Write(item + ",");
			}
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


		// Exercise 2.1-3
		// Write a linear search, which scans through the sequence,
		// looking for a value
		// input: a sequence of n numbers and a value v
		// output: an index i such that a[i] == v or null if the value
		// was not found
		static int? LinearSearch(int[] array, int valueToSearch)
		{
			int? valueIndex = null;
			for(int i = 0; i < array.Length; i++)
			{
				if(array[i] == valueToSearch)
				{
					valueIndex = i;
					return valueIndex;
				}
			}

			return valueIndex;
		}

	}
}
