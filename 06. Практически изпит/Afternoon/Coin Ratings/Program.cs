class Program
{
	static void Main()
	{
		System.Console.Write("N: ");
		int votes = int.Parse(Console.ReadLine());

		for (int i = 0; i < votes; i++)
		{
			System.Console.Write("Enter token: ");
			string tokenName = Console.ReadLine();
			System.Console.Write("Enter count: ");
			int tokenCount = int.Parse(Console.ReadLine());


		}
	}
}