class Program
{
    static private int dashesBetweenStarsCount = 0;
    static int leftDashesCount = 0;
    static int rightDashesCount = 0;
    static int drawingWidth = 0;

    static void Main(string[] args)
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        leftDashesCount = n * 3;
        drawingWidth = n * 5;
        rightDashesCount = drawingWidth - leftDashesCount - 2;

        PrintTopPart(n);
        PrintCenterPart(n);
        PrintBottomPart(n);
    }

    static void PrintTopPart(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('-', n * 3) + '*' + new string('-', dashesBetweenStarsCount) + '*'
                + new string('-', rightDashesCount));

            if (i != n - 1)
            {
                dashesBetweenStarsCount++;
                rightDashesCount--;
            }
        }
    }

    static void PrintCenterPart(int n)
    {
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('*', n * 3) + '*' + new string('-', dashesBetweenStarsCount) + '*'
                + new string('-', drawingWidth - leftDashesCount - (dashesBetweenStarsCount + 2)));
        }
    }

    static void PrintBottomPart(int n)
    {
        for (int i = 0; i < n / 2; i++)
        {
            if (i == n / 2 - 1)
            {
                Console.WriteLine(new string('-', leftDashesCount--) + "*" + new string('*', dashesBetweenStarsCount++) + "**" + new string('-', rightDashesCount--));
            }
            else if (n > 3)
            {
                Console.WriteLine(new string('-', leftDashesCount--) + "*" + new string('-', dashesBetweenStarsCount) + "*" + new string('-', rightDashesCount--));
                dashesBetweenStarsCount += 2;
            }
        }
    }
}