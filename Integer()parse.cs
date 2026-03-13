namespace Params
{
    internal class Program
    {
     
     public   static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            string input = Console.ReadLine();

            int number;

            if (int.TryParse(input, out number))
            {
                Console.WriteLine("Valid number: " + number);
            }
            else
            {
                Console.WriteLine("Invalid number entered");
            }
        }
    }
}
