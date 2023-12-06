using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class ListNode<T>
    {
        public T value;
        public ListNode<T>? Next;
        public ListNode<T>? Prev;

        public ListNode(T item)
        {
            value = item;
        }
    }
}
