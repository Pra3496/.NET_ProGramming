using System.Runtime.InteropServices;

namespace TestMainDemo263
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fir = 0;
            int sec = 0;

            Console.WriteLine("Calculator Class -> Addition");
            Calculator cal = new Calculator();

            Console.WriteLine("Enter the First Number :");
            fir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number :");
            sec = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of {0} and {1} is {2}", fir, sec, cal.Addition(fir, sec));

            Console.WriteLine("Enter the User Name :");
            String userName = Console.ReadLine();
            Console.WriteLine("Enter the Batch Name :");
            String Batch = Console.ReadLine();

            Console.WriteLine("Hello,{0}\n\tBatch Name is {1}", userName, Batch);

        }
    }
}