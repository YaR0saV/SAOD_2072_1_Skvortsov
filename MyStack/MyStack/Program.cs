using MySt;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new(10);
            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            stack.Push('D');
            stack.Push('E');
            stack.Push('F');
            stack.Push('G');
            stack.Push('H');
            stack.Push('I');
            stack.Push('E');
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Top());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Top());
            Console.WriteLine(stack.Clear);
            Console.WriteLine(stack.IsEmpty());
        }
    }
}