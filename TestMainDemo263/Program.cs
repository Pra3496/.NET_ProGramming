using System.Runtime.InteropServices;

namespace TestMainDemo263
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number :");
            
            int no = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            Console.WriteLine("Using For Loop");

            for (i=0;i<no;i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Using While Loop");
            i = 0;
            while(i != no)
            {
                Console.WriteLine(i);
                i++;
            }    

        }
    }
}