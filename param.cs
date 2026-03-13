namespace Params
{
    internal class Program
    {
         static void Changevalue(ref int a)
        {
            a = a + 10;
        }
        static void Main(string[] args)
        {
            int num = 5;
            Changevalue(ref num);
            Console.WriteLine("Total value:"+num);
        }
    }
}
