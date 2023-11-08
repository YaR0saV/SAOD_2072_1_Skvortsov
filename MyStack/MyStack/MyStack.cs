using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal class MyStack<T>
    { 
        private readonly int _Size;
        private readonly T[] _Array;
        private int _Top;
        public MyStack(int Size)
        {
            if (Size <= 0) { throw new ArgumentException("Maximum length must be more than 0."); }
            this._Size = Size;
            this._Top = 0;
            this._Array = new T[this._Size];
        }
        public int Top
        {
            get
            {
                return this._Top;
            }
        }
        public int Size
        {
            get
            {
                return this._Size;
            }
        }
        public int Count
        {
            get
            {
                return this._Top;
            }
        }
        public bool IsFull()
        {
            return this._Top == this._Size;
        }
        public bool IsEmpty()
        {
            return this._Top == 0;
        }
        public List<T> Values()
        {
            List<T> valuE = new ();
            foreach (var item in this._Array)
            {
                valuE.Add(item);
            }
            return valuE;
        }
        public void Push(T Element)
        {
            if (this.IsFull())
            {
                throw new InvalidOperationException("Stack is full.");
            }
            this._Array[this._Top++] = Element;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return this._Array[this._Top - 1];
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return this._Array[--this._Top];
        }
    }
}
