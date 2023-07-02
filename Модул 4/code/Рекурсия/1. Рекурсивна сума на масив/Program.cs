namespace _1._Рекурсивна_сума_на_масив
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter array: ");
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			Console.WriteLine(Sum(arr, 0));
		}

		static int Sum(int[] arr, int index) 
		{
			if (index == arr.Length - 1)
			{
				return arr[index];
			}

			return arr[index] + Sum(arr, index + 1);
		}
	}
}