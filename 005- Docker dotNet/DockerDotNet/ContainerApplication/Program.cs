namespace ContainerConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                int.TryParse(args[0], out int number1);
                int.TryParse(args[1], out int number2);
                Console.Write(number1 + number2);
            }
            else
            {
                throw new ArgumentException("Invalid number of arguments");
            }
        }
    }
}
