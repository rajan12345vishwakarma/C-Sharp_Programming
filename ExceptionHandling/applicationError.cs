namespace Practice
{
    public class DivideByOddNoException : ApplicationException
    {
        public override string Message { get { return "Attempt to divide by odd number"; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Ener second number");
                int y = int.Parse(Console.ReadLine());
                if (y % 2 > 0)
                {
                   // throw new ApplicationException("divisor value can't be odd number");
                    throw new DivideByOddNoException();
                }
                int res = x % y;
                Console.WriteLine($"result = {x / y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
               
            }
           
            Console.ReadLine();
        }
    }
}
