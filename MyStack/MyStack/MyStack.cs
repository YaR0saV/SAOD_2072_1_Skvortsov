namespace MySt
{
    public class MyStack<T>
    {
        private readonly T[] elem;     
        private int length;      
        private readonly int maxLength;   
        public MyStack(int maxLength)
        {
            if (maxLength <= 0) { throw new ArgumentException("Maximum length must be more than 0.");}
            length = 0;
            elem = new T[maxLength];
            this.maxLength = maxLength;
        }
        public void Clear()
        {
            length = 0;
        }
        public bool IsEmpty()
        {
            return length == 0;
        }
        public char Top()
        {
            if (IsEmpty()) { throw new InvalidOperationException("Stack is empty.");}
            return elem[length - 1];
        }
        public void Push(T element)
        {
            if (length == maxLength) { throw new InvalidOperationException("Stack is full.");}
            elem[length] = element;
            length++;
        }
        public char Pop()
        {
            if (IsEmpty()) { throw new InvalidOperationException("Stack is empty.");}
            char topElement = elem[length - 1];
            length--;
            return topElement;
        }
    }
}
