namespace _3._Рекурсивно_чертаене
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter n: ");
			int n = int.Parse(Console.ReadLine());
			PrintFigure(n);
		}

		private static void PrintFigure(int n)
		{
			if (n == 0)
			{
				return;
			}

			Console.WriteLine(new string('*', n));
			PrintFigure(n - 1);
			Console.WriteLine(new string('#', n));
		}
	}
}