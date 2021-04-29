using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int c=1;

            while(floor != Math.Abs(floor))
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                floor = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= floor; i++)
            {
                    
                 for (int j = 0; j <= i; j++)
                 {
                        
                     if (j ==0||j==i)
                     {
                        c = 1;
                     }
                     else
                     {
                        c = c * (i - j + 1) / j;
                     }
                     Console.Write(c);

                 }
                 Console.WriteLine();
            }
            Console.ReadLine();
            
        }

    }
}
