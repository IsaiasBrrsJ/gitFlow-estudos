using System.Runtime.CompilerServices;

namespace gitFlow
{
    internal class Program
    {
        delegate int dele(int a, int b); 
        static async Task   Main(string[] args)
        {
            dele del = Amaisb;
            var resultSum = -1;
            await Task.Run(() =>
             {
                 resultSum = del.Invoke(25, 75);

             });
            //.ContinueWith(t =>
            //{
                if (resultSum is 100)
                {
                    Console.WriteLine("is one hundred");
                    Console.WriteLine("there are hardly ever any mistakes in this code");
                }
            //});

           
            Console.WriteLine("Hello World");

            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Testing again");

            Console.WriteLine(  "another test again");

           await Task.Run(() =>
            {
                bool youCanDoThis = true;
                if (youCanDoThis)
                    Console.WriteLine("Hello there, you can do this, i truly aprecciate it");
            }).ConfigureAwait(false);

          

            Console.ReadKey();
        }

        static int Amaisb(int a, int b)
        {
            return a + b;
        }
    }
}
