namespace MyApplication_Module9
{
    internal class Program
    {/// <summary>
     /// Создайте свой тип исключения.
     /// Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. 
     /// Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения 
     /// (блок finally по желанию).
     /// В блоке catch выведите в консольном сообщении текст исключения.
     /// </summary>
        public class myException1 : Exception
        {
            public myException1() : base()
            { }
            public myException1(string message) : base(message)
            { }
        }
        public class  myException2 : ArgumentException
        {
            public myException2(string message) : base(message)
            { }
        }


        static void Main(string[] args)
        {
            int x = 5;
            int y = 0;


            try
            {
                Console.WriteLine("Блок try #1 начал работу");
                throw new myException1("Исключение1 сгенерировано.");

            }
            catch (Exception ex) when (ex is myException1)
            {
                Console.WriteLine("exception 1");
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Блок try#2 начал работу");
                if (x > 4) throw new myException2("Argument out of range");
            }
            catch (Exception ex) when (ex is myException2)
            {
                Console.WriteLine("exception 2");
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Блок try#3 начал работу");
                y = x / 0;
            }
            catch (Exception ex) when (ex is DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
                Console.WriteLine(ex.Message);

            }

            try
            {
                Console.WriteLine("Блок try#4 начал работу");
                function1(0);
            }
            catch (Exception ex) when (ex is ArgumentOutOfRangeException)
            {
                Console.WriteLine("ArgumentOutOfRangeException");
                Console.WriteLine(ex.Message);

            }

            try
            {
                Console.WriteLine("Блок try#5 начал работу");
                Method();
            }
            catch (Exception ex) when (ex is NotImplementedException)
            {
                Console.WriteLine("NotImplementedException");
                Console.WriteLine(ex.Message);

            }
        }

        static void function1(int x)
        {
            ArgumentOutOfRangeException.ThrowIfZero(x);
        }

        static void Method()
        {
            // Not developed yet.
            throw new NotImplementedException();
        }

    }
}
