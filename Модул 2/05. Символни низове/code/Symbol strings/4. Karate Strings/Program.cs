using System.Text;

namespace _4._Karate_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            StringBuilder input = new StringBuilder(Console.ReadLine());
            StringBuilder result = new StringBuilder(input.ToString());
            int remainingPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    int curPower = int.Parse(input[i + 1] + "") + remainingPower;
                    remainingPower = 0;

                    for (int delIndex = i + 1; delIndex < delIndex + curPower; delIndex++)
                    {
                        if (input[delIndex] == '>')
                        {
                            remainingPower += curPower;
                            break;
                        }

                        input[delIndex] = '_';
                        curPower--;
                    }
                }
            }

            Console.WriteLine(input.Replace("_", ""));
        }
    }
}