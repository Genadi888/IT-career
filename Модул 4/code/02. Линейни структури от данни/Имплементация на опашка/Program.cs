namespace Имплементация_на_опашка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularQueue<int> queue = new CircularQueue<int>();
            queue.Enqueue(1 , 2, 5555, 718);
            Console.WriteLine(queue);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue);
        }
    }
}