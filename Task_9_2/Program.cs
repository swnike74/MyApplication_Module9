﻿using System;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_9_2
{
    internal class Program
    {/// <summary>
     /// Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек.
     /// Сортировка должна происходить при помощи события.
     /// Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я),
     /// либо числа 2 (сортировка Я-А).
     /// Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию TryCatchFinally
     /// с использованием собственного типа исключения.
     /// </summary>
        static string[] ListofPerson =
            {
                "Иванов",
                "Петров",
                "Афанасьев",
                "Сидоров",
                "Естафьев"
            };
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += MakeDecision;

            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено неверное значение");
                }
            }

        }

        

        static void MakeDecision(int num)
        {
            switch(num)
            {
                case 1:
                    sort_forward(ListofPerson);
                    foreach (string s in ListofPerson)
                    {
                        Console.WriteLine(s);
                    }
                    break;
                case 2:
                    sort_backward(ListofPerson);
                    foreach (string s in ListofPerson)
                    {
                        Console.WriteLine(s);
                    }
                    break;

            }
        }

       
        public static void sort_forward(string[] ListofPerson)
        {
            string stemp = "";

            for (int i = 0; i < ListofPerson.Length; i++)
            {
                for (int j = i + 1; j < ListofPerson.Length; j++)
                {
                    char[] bytesj = ListofPerson[j].ToCharArray();
                    char[] bytesi = ListofPerson[i].ToCharArray();
                    if (bytesi[0] > bytesj[0])
                    {
                        stemp = ListofPerson[i];
                        ListofPerson[i] = ListofPerson[j];
                        ListofPerson[j] = stemp;
                    }
                }
            }
        }

        public static void sort_backward(string[] ListofPerson)
        {
            string stemp = "";

            for (int i = 0; i < ListofPerson.Length; i++)
            {
                for (int j = i + 1; j < ListofPerson.Length; j++)
                {
                    char[] bytesj = ListofPerson[j].ToCharArray();
                    char[] bytesi = ListofPerson[i].ToCharArray();
                    if (bytesi[0] < bytesj[0])
                    {
                        stemp = ListofPerson[i];
                        ListofPerson[i] = ListofPerson[j];
                        ListofPerson[j] = stemp;
                    }
                }
            }
        }
    }

    public class NumberReader
    {
        public delegate void NumberEnteredDelegate(int num);
        public event NumberEnteredDelegate? NumberEnteredEvent;

        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Enter digit 1 for Forward sorting or 2 for backward sorting");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new FormatException();

            NumberEntered(number);
        }
        protected virtual void NumberEntered(int num)
        {
            NumberEnteredEvent?.Invoke(num);
        }
    }
}
