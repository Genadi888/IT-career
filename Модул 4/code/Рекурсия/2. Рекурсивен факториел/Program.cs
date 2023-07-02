namespace _2._Рекурсивен_факториел
{
	internal class Program
	{
		static void Main(string[] args)
		{
			decimal n = decimal.Parse(Console.ReadLine());
			Console.WriteLine(Factorial(n));
		}

		static decimal Factorial(decimal n)
		{
			if (n == 1M)
			{
				return 1M;
			}

			return n * Factorial(n - 1M);
		}
	}
}