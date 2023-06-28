using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ExceptionFinalProject;

namespace ExceptionFinalProject
{
    internal class Task2
    {
        public static void ShowNum(int number)
        {
            switch (number)
            {
                case 1: Console.WriteLine("Вы нажали 1"); break;
                case 2: Console.WriteLine("Вы нажали 2"); break;
                default: Console.WriteLine("Меня никогда не вызовут.  8(  *хнык*"); break;
            }
        }
    }
    public class EnterNumber
    {
        public delegate void WorkWithNum(int number);
        public event WorkWithNum WorkWithNumber;
        public void Read()
        {
            Console.WriteLine("Введите 1 или 2.");
            int.TryParse(Console.ReadLine(), out int number);
            if (number != 1 && number != 2) throw new FormatException("Вы ввели недопустимое значение.");
            StartEvent(number);
        }
        public void StartEvent(int number)
        {
            WorkWithNumber?.Invoke(number);
        }
    }
}
