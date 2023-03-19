namespace _4.__Лотариен_Билет
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows and cols: ");
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split(' ')[0]);
            int cols = int.Parse(input.Split(' ')[1]);

            int[,] ticket = new int[rows, cols];

            for (int row = 0; row < rows; row++) // entering numbers
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("Enter num for [{0}][{1}]: ", row, col);
                    ticket[row, col] = int.Parse(Console.ReadLine());
                }
            }

            if (CheckIfTicketIsWinning(ticket))
            {
                Console.WriteLine("YES");
                Console.WriteLine("The amount of money won is: {0:F2}", CalculatePrize(ticket));
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool CheckIfTicketIsWinning(int[,] ticket)
        {
            int mainDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int sumAboveMainDiag = 0;
            int sumBelowMainDiag = 0;

            for (int row = 0; row < ticket.GetLength(0); row++) // entering numbers
            {
                for (int col = 0; col < ticket.GetLength(1); col++)
                {
                    int curNum = ticket[row, col];

                    if (row == col)
                    {
                        mainDiagonalSum += curNum;
                    }

                    if (row < col)
                    {
                        sumAboveMainDiag += curNum;
                    }
                    
                    if (row > col)
                    {
                        sumBelowMainDiag += curNum;
                    }

                    if (row + col == ticket.GetLength(0) - 1)
                    {
                        secondaryDiagonalSum += curNum;
                    }
                }
            }

            return mainDiagonalSum == secondaryDiagonalSum && sumAboveMainDiag % 2 == 0 && sumBelowMainDiag % 2 != 0;
        }

        static double CalculatePrize(int[,] ticket)
        {
            double sumBelowMainDiag = 0d;
            double evenNumsMainDiagonalSum = 0d;
            double evenNumsBorderRowsSum = 0d;
            double oddNumsBorderColsSum = 0d;

            for (int row = 0; row < ticket.GetLength(0); row++) // entering numbers
            {
                for (int col = 0; col < ticket.GetLength(1); col++)
                {
                    int curNum = ticket[row, col];

                    if (row > col)
                    {
                        sumBelowMainDiag += curNum;
                    }

                    if (row == col && curNum % 2 == 0)
                    {
                        evenNumsMainDiagonalSum += curNum;
                    }

                    if ((row == 0 || row == ticket.GetLength(0) - 1) && curNum % 2 == 0)
                    {
                        evenNumsBorderRowsSum += curNum;
                    }
                    
                    if ((col == 0 || col == ticket.GetLength(1) - 1) && curNum % 2 != 0)
                    {
                        oddNumsBorderColsSum += curNum;
                    }
                }
            }

            return (sumBelowMainDiag + evenNumsMainDiagonalSum + evenNumsBorderRowsSum + oddNumsBorderColsSum) / 4;
        }
    }
}