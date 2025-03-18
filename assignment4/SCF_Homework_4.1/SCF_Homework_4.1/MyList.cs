using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYLIST
{
    public class node<T>
    {
        public node<T> Next { get; set; }
        public T Data { get; set; }

        public node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class MyList<T>
    {
        private node<T> head;
        private node<T> tail;
        public MyList()
        {
            head = tail = null;
        }
        public node<T> Head { get => head; }
        public void Add(T t)
        {
            node<T> n = new node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            node<T> p = head;
            while(p!=null)
            {
               action(p.Data);
               p = p.Next;
            }
        }
    }
}
