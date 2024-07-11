using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutParams
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int num1 = 5;
            PrintIn(in num1);

            PrintOut(out int num2); //num2 does not need to be initialized.

            PrintParams("Sufyan", "Rizvi"); // params parameters take multiple inputs and put into an array. they are placed at the last of any parameters.

            IntTryParse();

            WriteLineParams();

        }

        static void PrintIn(in int num)
        {
            //num = 5; //line wont work as "in" makes the parameter read-only, 
            Console.WriteLine(num);
        }

        static void PrintOut(out int num2)
        {
            num2 = 5; // "out" parameters are meant to be modified and do not need to be initialized beforehand.

            Console.WriteLine(num2);

        }

        static void PrintParams(params string[] Names)
        {
            //POC on params

            foreach (string name in Names)
                Console.WriteLine(name);
        }

        static void IntTryParse()
        {
            int myNumber;
            Console.WriteLine("Enter your number: ");
            
            bool result = int.TryParse(Console.ReadLine(), out myNumber); //int.TryParse returns a bool and an outputs a variable if the datatype matches

            if (result)
                Console.WriteLine("Correct Number: " + myNumber);
            else
                Console.WriteLine("Enter a Number: ");

        }
        static void WriteLineParams()
        {
            Console.WriteLine("Hi my fname is {0}, sname is {1}", "Sufyan", "Rizvi");
        }
        




    }

}
