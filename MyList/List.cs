using System;
namespace MyList
{
    public class List
    {
        private Node _head;
        private Node _tail;
        public int Count { get; private set; }
        public void AddLast(char val)
        {
            var tmp = new Node() 
            {
                Data = val 
            };
            if (Count == 0)
                _head = _tail = tmp;
            else
            {
                _tail.Next = tmp;
                tmp.Prev = _tail;
                _tail = tmp;
            }

            Count++;
        }
        public void InsertAt(char val, int ind)
        {
            if (ind < 0 || ind > Count)
                throw new Exception("Wrong index");
            if (ind == Count)
                AddLast(val);
            else if (ind == 0)
            {
                var tmp = new Node()
                { 
                    Data = val
                };
                tmp.Next = _head;

                if (Count != 0)
                    _head.Prev = tmp;

                if (Count == 0)
                    _head = _tail = tmp;
                else
                    _head = tmp;

                Count++;
            }
            else
            {
                int i = 0;
                var ins = _head;
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
            if (ind < 0 || ind >= Count)
                throw new Exception("Wrong index");
            int i = 0;
            var target = _head;
            while (i != ind)
            {
                target = target.Next;
                i++;
            }
            return target.Data;
        }
        public char RemoveAt(int ind)
        {
            if (ind < 0 || ind >= Count)
                throw new Exception("Wrong index");
            int i = 0;
            var del = _head;
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
                _head = nextNode;
            if (ind == Count - 1)
                _tail = prevNode;

            Count--;
            return del.Data;
        }
        public void RemoveAll(char data)
        {
            int i = 0;
            var current = _head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    RemoveAt(i);
                    i--;
                }
                current = current.Next;
                i++;
            }
        }
        public List Clone()
        {
            List cloneList = new List();
            var current = _head;
            while (current != null)
            {
                cloneList.AddLast(current.Data);
                current = current.Next;
            }
            return cloneList;
        }
        public void Reverse()
        {
            var current = _head;
            for (int i = 0, j = Count - 1; i < j; i++)
            {
                char temp = Get(j);
                RemoveAt(j);
                InsertAt(temp, i);
            }
        }
        public int FindFirst(char target)
        {
            int targetInd = -1;
            var current = _head;
            int i = 0;
            while (current != null)
            {
                if(Get(i) == target)
                {
                    targetInd = i;
                    break;
                }
                current = current.Next;
                i++;
            }
            return targetInd;
        }
        public int FindLast(char target)
        {
            int targetInd = -1;
            var current = _tail;
            int i = Count - 1;
            while (current != null)
            {
                if (Get(i) == target)
                {
                    targetInd = i;
                    break;
                }
                current = current.Prev;
                i--;
            }
            return targetInd;
        }
        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
        public void Extend(List elements)
        {
            var current = elements._head;
            while (current != null)
            {
                AddLast(current.Data);
                current = current.Next;
            }
        }
        public void PrintForward()
        {
            var cur = _head;
            while (cur != null)
            {
                Console.Write($"{cur.Data} ");
                cur = cur.Next;
            }

            Console.WriteLine();
        }
    }
}
