namespace Task_9_2
{
    internal class Program
    {
        public class myException : Exception
        {
            public myException()
            { }

            public myException (string message) : base(message)
            { }
        }



        static void Main(string[] args)
        {
            myException[] myExceptions = new myException[5];

            try
            {
                Console.WriteLine("Блок try начал работу");
                throw new myException("1");
            }
            catch (Exception ex) when (ex is myException)
            {
                Console.WriteLine("exception 1");
                Console.WriteLine(ex.Message);
            }


        }
    }
}
