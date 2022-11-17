class Generate_Codes
{
	static void Main()
	{
		System.Console.WriteLine("m: ");
		int passwordNum = int.Parse(Console.ReadLine());
		System.Console.WriteLine("n: ");
		int countOfCodes = int.Parse(Console.ReadLine());

		for (int i = 0; i <= 9; i++)
		{
			for (int j = 0; j <= 9; j++)
			{
				for (int k = 0; k <= 9; k++)
				{
					for (char l = 'a'; l <= 'z'; l++)
					{
						for (char m = 'a'; m <= 'z'; m++)
						{
							for (int n = 0; n <= 9; n++)
							{
								int sum = i + j + k + l + m + n;
								if (sum == passwordNum)
								{
									Console.Write("{0}{1}{2}{3}{4}{5} ", i, j, k, l, m, n);
									countOfCodes--;
									if (countOfCodes == 0)
									{
										return;
									}
								}
							}
						}
					}
				}
			}
		}
	}
}