
namespace MyList
{
    public class List
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public int Count { get; private set; }
        public void AddLast(char val)
        {
            var tmp = new Node() 
            {
                Data = val 
            };
            if (Count == 0)
                Head = Tail = tmp;
            else
            {
                Tail.Next = tmp;
                tmp.Prev = Tail;
                Tail = tmp;
            }

            Count++;
        }
    }
}
