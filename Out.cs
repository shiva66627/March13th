namespace Params
{
    internal class Program
    {
      public   static void Changevalue(out int a)
        {
            a =  10;
            a += a;

        }
     public   static void Main(string[] args)
        {
            int a;
            Changevalue(out a);
            Console.WriteLine("Total value:"+a);
        }
    }
}
