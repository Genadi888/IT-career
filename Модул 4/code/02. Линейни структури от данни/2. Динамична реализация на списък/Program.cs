namespace _2._Динамична_реализация_на_списък
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicList list = new DynamicList();
            list.Add(6);
            list.RemoveAt(0);
            list.Add(1);
            list.Add(1);
            list.Add(3);
            list.Add(5);
            
            Console.WriteLine(list.Remove(5));
            list.Add("heyy");
            Console.WriteLine(list);
            //list.RemoveAt(0);
            list[-4] = "textt";
            Console.WriteLine(list);

        }
    }
}