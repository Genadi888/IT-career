using System.Text;

namespace _1._StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter statement: ");
            StringBuilder statement = new StringBuilder(Console.ReadLine());
            Console.Write("Enter command: ");
            string[] commandTokens = Console.ReadLine().Split();

            switch (commandTokens[0])
            {
                case "Append": statement.Append(commandTokens[1]); break;
                case "Remove": statement.Remove(int.Parse(commandTokens[1]), int.Parse(commandTokens[2])); break;
                case "Insert": statement.Insert(int.Parse(commandTokens[1]), commandTokens[2]); break;
                case "Replace": statement.Replace(commandTokens[1], commandTokens[2]); break;
            }

            Console.WriteLine(statement);
        }
    }
}