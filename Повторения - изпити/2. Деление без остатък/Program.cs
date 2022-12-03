class Program
{
    static void Main(string[] args)
    {
        Console.Write("Number count: ");
        double numberCount = double.Parse(Console.ReadLine());
        double multiplesOf2 = 0;
        double multiplesOf3 = 0;
        double multiplesOf4 = 0;

        for (int i = 0; i < numberCount; i++)
        {
            Console.Write("Number: ");
            double n = double.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                multiplesOf2++;
            }
            if (n % 3 == 0)
            {
                multiplesOf3++;
            }
            if (n % 4 == 0)
            {
                multiplesOf4++;
            }
        }

        Console.WriteLine("{0:f2}%", (multiplesOf2 / numberCount) * 100);
        Console.WriteLine("{0:f2}%", (multiplesOf3 / numberCount) * 100);
        Console.WriteLine("{0:f2}%", (multiplesOf4 / numberCount) * 100);
    }
}