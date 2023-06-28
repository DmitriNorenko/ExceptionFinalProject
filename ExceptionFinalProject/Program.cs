using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[]
            {
                new ArgumentException(),
                new DivideByZeroException(),
                new FileNotFoundException(),
                new FormatException(),
                new MyException(),
            };
            foreach (Exception ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (Exception exception)
                {
                    if (exception is ArgumentException) Console.WriteLine("Ошибка №1 - ArgumentException.");
                    if (exception is DivideByZeroException) Console.WriteLine("Ошибка №2 - DivideByZeroException.");
                    if (exception is FileNotFoundException) Console.WriteLine("Ошибка №3 - FileNotFoundException.");
                    if (exception is FormatException) Console.WriteLine("Ошибка №4 - FormatException.");
                    if (exception is MyException) Console.WriteLine("Ошибка №5 - MyException.");
                }
            }
            Console.ReadKey();
        }
        public class MyException : Exception
        {
            public MyException() { }
            public MyException(string message) : base(message) { }
        }
    }
}
