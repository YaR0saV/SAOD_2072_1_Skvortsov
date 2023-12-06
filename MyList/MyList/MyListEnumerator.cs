using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class MyListEnumerator<T> : IEnumerator<T>
    {
        private ListNode<T>? _currentNode;
        private ListNode<T>? First;
        public MyListEnumerator(ListNode<T> First)
        {

            this.First = First;
        }

        public bool MoveNext() // решить
        {
            if (_currentNode == null)
                _currentNode = First;
            else
                _currentNode = _currentNode.Next;
            return _currentNode != null;
        }

        public void Reset()
        {
            _currentNode = null;
        }

        public void Dispose()
        {

        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get
            {
                return _currentNode.value;
            }
        }
    }
}
