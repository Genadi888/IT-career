namespace _3._Минимум_по_колони
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rows: ");
            int rows = int.Parse(Console.ReadLine());
            rows++;
            Console.Write("Cols: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == rows - 1) // set min value for column
                    {
                        int smallestNum = int.MaxValue;
                        for (int rowIndex = 0; rowIndex < rows - 1; rowIndex++) // find min value
                        {
                            if (matrix[rowIndex, col] < smallestNum)
                            {
                                smallestNum = matrix[rowIndex, col];
                            }
                        }
                        matrix[row, col] = smallestNum;
                        continue;
                    }

                    Console.Write("Enter num for [{0}][{1}]: ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0, 10}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}