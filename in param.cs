namespace Params
{
    internal class Program
    {
      public   static void Changevalue(in int b)
        {
            Console.WriteLine(b);   

        }
     public   static void Main(string[] args)
        {
            int a=90;
            Changevalue(in a);
           
        }
    }
}
