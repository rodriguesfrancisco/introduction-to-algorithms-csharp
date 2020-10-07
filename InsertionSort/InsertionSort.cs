using System;

namespace InsertionSort
{
	class InsertionSort
	{
		static void Main(string[] args)
		{
			int[] array = new int[] { 5, 2, 4, 6, 1, 3, 12, 123, 65, 7, 24 };

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

			foreach (var item in array)
			{
				Console.Write(item + ",");
			}

			Console.WriteLine();
		}
	}
}
