using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KulikovLibrary;

namespace TestMyDll
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = matOperations.Add(20, 13);
            Console.WriteLine("Результат сложения: " + sum);

            int minus = matOperations.Substract(20, 13);
            Console.WriteLine("Результат вычитания: " + minus);

            int mul = matOperations.Multi(20, 13);
            Console.WriteLine("Результат умножения: " + mul);

            try
            {
                double divisionByZero = matOperations.Divide(20, 13);
                Console.WriteLine("Деление чисел: " + divisionByZero);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }


            try
            {
                double divisionByZero = matOperations.Divide(20, 0);
                Console.WriteLine("Деление чисел: " + divisionByZero); 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
