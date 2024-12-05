namespace MyApplication_Module9
{
    internal class Program
    {
        public class myException : Exception
        {
            public myException()
            { }
            public myException(string message) : base(message)
            { }
        }

        myException[] myExceptions = new myException[5];

        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Блок try начал работу");
                throw new myException();
                    
            }
            catch (Exception ex) when (ex is myException)
            {
                Console.WriteLine("exception 1");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
