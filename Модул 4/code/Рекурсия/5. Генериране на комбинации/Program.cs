namespace _5._Генериране_на_комбинации
{
	internal class Program
	{
		private static List<int> inputList;
		private static int groupLength;

		static void Main(string[] args)
		{
			Console.Write("Enter list: ");
			inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			Console.Write("Enter k: ");
			groupLength = int.Parse(Console.ReadLine());
			PrintCombinations(0, groupLength - 1);
		}

		private static void PrintCombinations(int baseIndex, int curIndex)
		{
			List<int> printList = new List<int>();

			printList.AddRange(inputList.GetRange(baseIndex, groupLength - 1));
			printList.Add(inputList[curIndex]);

			Console.WriteLine(String.Join(' ', printList));

			//int nextCurIndex = baseIndex + groupLength;

			if (baseIndex == inputList.Count - groupLength) //bottom of recursion
			{
				return;
			}

			if (curIndex + 1 == inputList.Count)
			{
				PrintCombinations(baseIndex + 1, baseIndex + groupLength);
			} 
			else
			{
				PrintCombinations(baseIndex, curIndex + 1);
			}
		}
	}
}