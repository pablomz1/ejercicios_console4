using System;
using System.Threading;



namespace ejercicios_console4
{
    class Program
    {
        static class Constants
        {
            public const int ca = 1948;
            public const int c4 = 4;

        }

        static void Main(string[] args)
        {

            string va = "pablo";
            string vb = "mendez";
            string vc = "lencina";
            var vuno = 22;
            var vdos = 05;
            var vtres = 79;
            var c = 0;
           


        Console.WriteLine(va);
            Thread.Sleep(2000);
            Console.WriteLine(vb + " " + vc + " " + va);
            Thread.Sleep(2000);
            Console.WriteLine(vuno + "/" + vdos + "/" + vtres);
            Thread.Sleep(2000);
            c = Constants.ca;
            var contador = 0;
            while (c < 2021)
            {
                contador++;
                c = Constants.c4 + c;                     
            }


            Thread.Sleep(2000);
            Console.WriteLine(contador);
            Thread.Sleep(2000);
            for (int i = Constants.ca; i < vtres ; i++ * 4  )
            {

            }







    }
    }
}
