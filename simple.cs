using System;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class Proggramm 
    {
        static async Task<int> DoStuff()
        {
            var x = await System.IO.File.ReadAllTextAsync("Foo");
            var y = await System.IO.File.ReadAllTextAsync("Bar");
            return x.Lenght + y.Lenght;
        }

        static void Main(string[] args)
        {
            var lenghts = DoStuff().Result;
            Console.WriteLine($"Hello World! {lengths}");
        }
    }
}