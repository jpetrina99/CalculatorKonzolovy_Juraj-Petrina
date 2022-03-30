using System;

namespace CalculatorKonzolovy_Juraj_Petrina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator:");

            Console.Write("Please enter a value: ");
            double Num = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();
            Console.Write("Please enter a second value: ");
            double Num2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();

            Console.Write("Choose 1 = multiply, 2 = subtract, 3 = add, 4 = devide: ");
            int Ch = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            // True
            if (Ch == 1){
                double Ans1 = Num * Num2;
                Console.WriteLine("Output: {0} ", Ans1);
            }
            
            if (Ch == 2 )
            {
                double Ans2 = Num - Num2;
                Console.WriteLine("Output: {0} ", Ans2);   
            }

              if (Ch == 3)
            {
               double Ans3 = Num + Num2;
                Console.WriteLine("Output: {0} ", Ans3);

                
            }

              if (Ch == 4 )
            {
                double Ans4 = Num / Num2;
                Console.WriteLine("Output: {0} ", Ans4);   
            }
            // False
            if (Ch < 1){
                Console.WriteLine("Sorry there's been an error.");
                Console.WriteLine("Try again.");
            }
            if (Ch > 4){
                Console.WriteLine("Sorry there's been an error.");
                Console.WriteLine("Try again.");
            }
            if (Ch < 2 && Ch > 1){
                Console.WriteLine("Sorry there's been an error.");
                Console.WriteLine("Try again.");
            }
            if (Ch > 3 && Ch < 2){
                Console.WriteLine("Sorry there's been an error.");
                Console.WriteLine("Try again.");
            }
            if (Ch > 4 && Ch < 3){
                Console.WriteLine("Sorry there's been an error.");
                Console.WriteLine("Try again.");
            }else{
                Console.WriteLine("Try again!");
            }




            Console.ReadKey();
        }
    }
}
