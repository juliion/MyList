using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.AddLast('a');
            list.AddLast('b');
            list.AddLast('c');
            Console.WriteLine("List after adding 3 elements('a', 'b', 'c') to the end:");
            list.PrintForward();
            Console.WriteLine();
            list.InsertAt('d', 1);
            Console.WriteLine("List after insert element('d') at index 1:");
            list.PrintForward();
            Console.WriteLine();
            Console.WriteLine($"Get element at index 1: {list.Get(1)}");
            Console.WriteLine();
            list.RemoveAt(1);
            Console.WriteLine("List after remove element at index 1:");
            list.PrintForward();
            Console.WriteLine();
            List cloneList = list.Clone();
            Console.WriteLine("Clone list:");
            cloneList.PrintForward();
            Console.WriteLine();
            list.Reverse();
            Console.WriteLine("List after reverse:");
            list.PrintForward();
            Console.WriteLine();
            list.AddLast('a');
            list.PrintForward();
            Console.WriteLine($"Find the first entry of the character 'a': {list.FindFirst('a')}");
            Console.WriteLine($"Find the last entry of the character 'a': {list.FindLast('a')}");
            Console.WriteLine();
            list.RemoveAll('a');
            Console.WriteLine("List after remove all entries 'a':");
            list.PrintForward();
            Console.WriteLine();
            list.Extend(cloneList);
            Console.WriteLine("List after expanding with list{'a', 'b', 'c'}:");
            list.PrintForward();
            Console.WriteLine();
            list.Clear();
            list.AddLast('k');
            Console.WriteLine("List after clear and add 'k':");
            list.PrintForward();
            Console.WriteLine();
        }
    }
}
