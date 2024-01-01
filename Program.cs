namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLZ ENTER A NUM>0");
            int x = int.Parse(Console.ReadLine());
            int y = fib(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
        static int fib(int x)
        {
            if (x <= 2)
                return x - 1;
            else
                return fib(x - 1) + fib(x - 2);
        }
    }
    
}
