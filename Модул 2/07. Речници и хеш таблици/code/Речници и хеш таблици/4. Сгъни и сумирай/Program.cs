namespace _4._Сгъни_и_сумирай
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 4*k long array of integers: ");
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int k = input.Count / 4;

            List<int> firstReversedPart = input.Take(k).Reverse().ToList();
            firstReversedPart.AddRange(input.TakeLast(k).Reverse());

            int[,] table = new int[3, 2 * k];

            for (int col = 0; col < firstReversedPart.Count; col++)
            {
                table[0, col] = firstReversedPart[col]; // filling the first row
            }
            
            for (int col = k; col < input.Count - k; col++) // we skip the first and last k numbers
            {
                table[1, col - k] = input[col]; // filling the second row
            }

            for (int col = 0; col < table.GetLength(1); col++) // we sum the numbers
            {
                table[2, col] = table[0, col] + table[1, col]; // filling the third row
                Console.Write(table[2, col] + " ");
            }


        }
    }
}