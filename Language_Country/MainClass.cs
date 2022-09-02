using System;

enum Country : byte
{
    Afghanistan=1,
    India,
    Bangladesh,
    Pakistan,
    Japan,
    China,
    Korea
}

namespace Language_Country
{
    internal class MainClass
    {
        static void Main()
        {
            Country myCountry;
            Console.WriteLine("Please choose a country");
            myCountry = (Country) byte.Parse(Console.ReadLine());

            switch (myCountry)
            {
                case Country.India:

                case Country.Pakistan:

                case Country.Bangladesh:

                case Country.Afghanistan:
                    Console.WriteLine("Language spoken in {0} is Hindi", myCountry);
                    break;

                case Country.China:
                    Console.WriteLine("Language spoken in {0} is Chinese", myCountry);
                    break;
            }
        }
    }
}
