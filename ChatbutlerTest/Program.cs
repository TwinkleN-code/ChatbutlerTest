using System;

namespace ChatbutlerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Butler james = new Butler();        //click ctrl+. en maak een new file Butler class
            //laat de butler groeten
            Console.Write(james.Greet());
            //Console.ReadKey();
        }
    }
}

