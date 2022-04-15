
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
        public void InsertAt(char val, int ind)
        {
            if (ind == Count + 1)
                AddLast(val);
            else if (ind == 0)
            {
                var tmp = new Node()
                { 
                    Data = val
                };
                tmp.Next = Head;

                if (Count != 0)
                    Head.Prev = tmp;

                if (Count == 0)
                    Head = Tail = tmp;
                else
                    Head = tmp;

                Count++;
            }
            else
            {
                int i = 0;
                var ins = Head;
                while (i < ind)
                {
                    ins = ins.Next;
                    i++;
                }
                var prevIns = ins.Prev;
                var tmp = new Node()
                {
                    Data = val
                };
                if (prevIns != null && Count != 1)
                    prevIns.Next = tmp;
                tmp.Next = ins;
                tmp.Prev = prevIns;
                ins.Prev = tmp;

                Count++;
            }
        }
        public char Get(int ind)
        {
            int i = 0;
            var target = Head;
            while (i != ind)
            {
                target = target.Next;
                i++;
            }
            return target.Data;
        }
        public char RemoveAt(int ind)
        {
            int i = 0;
            var del = Head;
            while (i != ind)
            {
                del = del.Next;
                i++;
            }

            var prevNode = del.Prev;
            var nextNode = del.Next;

            if (prevNode != null && Count != 1)
                prevNode.Next = nextNode;
            if (nextNode != null && Count != 1)
                nextNode.Prev = prevNode;
            if (ind == 0)
                Head = nextNode;
            if (ind == Count - 1)
                Tail = prevNode;

            Count--;
            return del.Data;
        }
    }
}
