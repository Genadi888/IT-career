class Program
{
	static void Main()
	{
		System.Console.Write("n: ");
		int n = int.Parse(Console.ReadLine());
		int slashesCount = n;
		int dashesCount = 6;
		int spacesCount = n * 2;

		System.Console.WriteLine(new string(' ', spacesCount) + new string('\\', slashesCount) + new string('/', slashesCount));
		slashesCount--;
		spacesCount -= 2;

		// ? top part
		for (int i = 0; i < n - 1; i++)
		{
			System.Console.WriteLine(new string(' ', spacesCount) + new string('\\', slashesCount) + new string('-', dashesCount) + new string('/', slashesCount));

			if (i < n - 2)
			{
				slashesCount--;
				spacesCount -= 2;
				dashesCount += 6;
			}
		}

		// ? middle part
		for (int i = 0; i < (n % 2 == 0 ? n - 1 : n - 2); i++)
		{
			if (n == 3)
			{
				System.Console.WriteLine("|~~/// ESTD \\\\\\~~|");
				break;
			}

			if (i + 1 == n / 2) //? in the middle
			{
				System.Console.WriteLine("|{0}{1} ESTD {2}{3}|", new string('~', n - 1), new string('/', (n * 4 - 6) / 2), new string('\\', (n * 4 - 6) / 2), new string('~', n - 1));
			}
			else
			{
				System.Console.WriteLine("|{0}{1}{2}|", new string('-', n - 1), new string('#', n * 4), new string('-', n - 1));
			}

		}

		// ? bottom part
		for (int i = n - 1; i >= 0; i--)
		{
			System.Console.WriteLine(new string(' ', spacesCount) + new string('/', slashesCount) + new string('-', dashesCount) + new string('\\', slashesCount));
			slashesCount++;
			spacesCount += 2;
			dashesCount -= 6;
		}

		// System.Console.WriteLine(new string(' ', spacesCount) + new string('/', slashesCount) + new string('\\', slashesCount));
	}
}