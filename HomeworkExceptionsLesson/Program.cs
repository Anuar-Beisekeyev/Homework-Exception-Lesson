using System;

namespace HomeworkExceptionsLesson
{
    /*
    1.	Реализовать метод деления двух чисел.Внутри метода проверять входящие параметры.Если они не заданы,
        то генерировать исключение ArgumentNullException.Если делитель равен нулю, то генерировать исключение ArgumentException.
    2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы.
        После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
    */

    class Program
    {
        static void Main(string[] args)
        {
            
            
            try
            {
                double result = Division(45, 0);
                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("--------------------\n");

            int size = 5;
            int[] array = new int[size];
            
            Random random = new Random();
            
            try
            {
                for (int i = 0; i < size; i++)
                {
                    array[i] = random.Next(1, 50);
                }
                for (int i = 0; i < size + 1; i++)
                {
                    Console.WriteLine(array[i]);
                }
                
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }
        static double Division(double num1, double num2)
        {
            double result;
            if (num1 == null && num2 == null)
            {
                throw new ArgumentNullException("Параметры не заданы");
            }
            if (num2 == 0)
            {
                throw new ArgumentException("Делить на 0 недопустимо");
            }
            return result = num1 / num2;
            
        }  

    }
}
