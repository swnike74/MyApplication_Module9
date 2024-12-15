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
        


        static void Main(string[] args)
        {
            string[] ListofPerson =
            {
                "Иванов",
                "Петров",
                "Афанасьев",
                "Сидоров",
                "Естафьев"
            };
            string stemp = "";
            
            for (int i = 0; i < ListofPerson.Length; i++)
            {
                for (int j = i + 1; j < ListofPerson.Length; j++)
                {
                    char[] bytesj = ListofPerson[j].ToCharArray();
                    char[] bytesi = ListofPerson[i].ToCharArray();
                    if ( bytesi[0] > bytesj[0] )
                    {
                        stemp = ListofPerson[i];
                        ListofPerson[i] = ListofPerson[j];
                        ListofPerson[j] = stemp;
                    }
                }
            }
            int x = 0;

        }
    }
}
