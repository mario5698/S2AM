using System;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args){

            int km, preu;
            double preuxkm;

            Console.WriteLine("KM :");

            km = Console.ReadLine();

            Console.WriteLine("Preu Per KM  :");

            preu = Console.ReadLine();


            preuxkm = km * preu;

            Console.WriteLine("Preu: " + preuxkm);
                }

       
    }
}
