namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4; 
            int b = 2; 
            int c = 1;
            int d = 9   ;
            for (int i = 1; i < 4; i++)
            {
                a = c + b;
                b += c;
                c -= a ;
                d = (b- c) + i;
            }
            Console.WriteLine(d);
        }
    }
}
