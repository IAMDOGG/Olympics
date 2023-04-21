using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double scoresum = 0;

            Console.WriteLine("\nWELCOME TO OLYMPICS\n");

            double[] scores = new double[8];
            for (int i = 0; i <8; i++)
            {
                Console.Write("Enter the score of judge [" +(i+1)+ "] : ");
                scores[i] = Convert.ToDouble(Console.ReadLine());
            }
            Array.Sort(scores);
            for (int i = 1; i <= 6; i++) { 
             scoresum += scores[i];
            }
            Console.WriteLine("\nThe contestant receives a total of {0:F2} points.", scoresum);
        }
    }
}
