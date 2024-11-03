using System;
using System.Transactions;

namespace First_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int ModelSmall = 25; 
              int ModelLarag = 35;
              Console.WriteLine("Enter  the number of small and larag rooms");
              Console.WriteLine("enter the number small room");
              int Smoll =int.Parse(Console.ReadLine());
              Console.WriteLine("enter the number large room");
              int large =int.Parse(Console.ReadLine());
              int Cost =  ModelSmall* Smoll + ModelLarag* large;
              double SalseTax = 6 / 100.0;
              double Tax = Cost * SalseTax; 

              Console.WriteLine("Estimate for carpet cleaning service");

              Console.WriteLine($"Number of small carpets:{Smoll}");
              Console.WriteLine($"Number of large carpets:{large}");
              Console.WriteLine($"Price per small romm:{ModelSmall}");
              Console.WriteLine($"Price per large  romm:{ModelLarag}");
              Console.WriteLine($"Cost: {Cost}");
              Console.WriteLine($"Tax: { Tax}");
            Console.WriteLine("==================");
            Console.WriteLine($"total estimate:{Tax + Cost}");
            Console.WriteLine("This estimate is valid for 30 Days");
            

        

        }
    }
}
