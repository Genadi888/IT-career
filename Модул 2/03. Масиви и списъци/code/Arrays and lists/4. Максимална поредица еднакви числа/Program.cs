using System.Linq;
using System.Collections.Generic;

namespace _4._Максимална_поредица_еднакви_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter list: ");
            List<int> inputList = Console.ReadLine().Split(' ').ToList().Select(int.Parse).ToList();
            List<int> leftmostLongestSequence = new List<int> { };

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                int curNum = inputList[i];
                int nextNum = inputList[i + 1];

                // we found a sequence
                if (curNum == nextNum)
                {
                    List<int> currentSequence = new List<int> { };
                    currentSequence.Add(curNum);

                    int seqIndex = i + 1;
                    while (curNum == nextNum)
                    {
                        currentSequence.Add(nextNum);
                        if (++seqIndex == inputList.Count) // if next index is out of bounds
                        {
                            break;
                        }
                        nextNum = inputList[seqIndex];
                    }
                    i = seqIndex - 1;

                    if (currentSequence.Count > leftmostLongestSequence.Count)
                    {
                        leftmostLongestSequence = currentSequence;
                    }
                }
            }

            Console.WriteLine(String.Join(' ', leftmostLongestSequence));

        }
    }
}