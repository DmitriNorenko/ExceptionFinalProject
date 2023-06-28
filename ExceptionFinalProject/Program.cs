using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionFinalProject;

namespace ExceptionFinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Начало.\n");
            Exception[] exceptions = new Exception[]
            {
                new ArgumentException("Ошибка №1 - ArgumentException."),
                new DivideByZeroException("Ошибка №2 - DivideByZeroException."),
                new FileNotFoundException("Ошибка №3 - FileNotFoundException."),
                new FormatException("Ошибка №4 - FormatException."),
                new MyException("Ошибка №5 - MyException."),
            };
            foreach (Exception ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (Exception exception)
                {
                    if (exception is ArgumentException) Console.WriteLine(exception.Message);
                    if (exception is DivideByZeroException) Console.WriteLine(exception.Message);
                    if (exception is FileNotFoundException) Console.WriteLine(exception.Message);
                    if (exception is FormatException) Console.WriteLine(exception.Message);
                    if (exception is MyException) Console.WriteLine(exception.Message);
                }
            }
            Console.WriteLine("\nЗадание 1. Конец.\n");
            Console.WriteLine("Задание 2. Начало.\n");
            EnterNumber enterNumber = new EnterNumber();
            enterNumber.WorkWithNumber += Task2.SortingRows;
            bool IsWork = true;
            while (IsWork)
            {
                try
                {
                    enterNumber.Read();
                    IsWork = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("\nЗадание 2. Конец.\n");
            Console.ReadKey();
        }
        public class MyException : Exception
        {
            public MyException() { }
            public MyException(string message) : base(message) { }
        }
    }
}
