class Program
{
    static void Main(string[] args)
    {
        Console.Write("V: ");
        int volume = int.Parse(Console.ReadLine());
        Console.Write("Debit of first pipe: ");
        int debit1PerHour = int.Parse(Console.ReadLine());
        Console.Write("Debit of second pipe: ");
        int debit2PerHour = int.Parse(Console.ReadLine());
        Console.Write("Hours absent: ");
        double hoursAbsent = double.Parse(Console.ReadLine());

        double firstPipeContribution = debit1PerHour * hoursAbsent;
        double secondPipeContribution = debit2PerHour * hoursAbsent;
        double litersFilled = firstPipeContribution + secondPipeContribution;

        if (litersFilled <= volume)
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Floor((litersFilled / volume) * 100),
                Math.Floor((firstPipeContribution / litersFilled) * 100), Math.Floor((secondPipeContribution / litersFilled) * 100));
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.", hoursAbsent, litersFilled - volume);
        }
    }
}