//Enrick De Munter 5ITN nr3 12/1/2020 brandstofkost
/*
 * OPGAVE
 * ======
 * kostprijs per KM
 * Diesel of benzine        diesel = 1.5900
 *                          super 95 = 1.5140
 *                          super 97 = 1.6020
 *
 * Aantal getankte liters
 * liters over
 * km gereden
 *
 * VRAAG    rijd u met DIESEL, super 95 of super 97
 *          wat is het aantal km die u heeft gereden
 *          HVL   liter heeft u getankt
 *          HVL   liter heeft u over
 *
 * BEREKEN      ALS diesel
 *              DAN  SOM = 1,5900 * (getankt liter - liter over) totsom = som / aantal KM
 *              ALS super95
 *              DAN SOM = 1,5140 * (getankt liter - liter over) totsom = som / aantal KM
 *              ALS super97
 *              DAN SOM = 1,6020 * (getankt liter - liter over) totsom = som / aantal KM
 *
 * TOON     de brandstof kost totsom               
 *
 *
 *
 *
 */


using System;

namespace Brandstofkost
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //variabelen
            ushort soort, Diesel = 1, super95 = 2, super97 = 3 ;
            ushort aantalKilometer, som1;
            decimal   som2, totsom;
            
            byte aantaLiterGetankt, aantalLiterOver;
            // VRAAG    rijd u met DIESEL typ 1, super 95 typ 2 of super 97 typ3
            Console.WriteLine("rijd u met DIESEL typ 1, super 95 typ 2 of super 97 typ3");
            soort = ushort.Parse(Console.ReadLine());
            //          wat is het aantal km die u heeft gereden
            Console.WriteLine("wat is het aantal km die u heeft gereden?");
            aantalKilometer = ushort.Parse( Console.ReadLine());
            //          HVL   liter heeft u getankt
            Console.WriteLine("hvl liter heeft u getankt");
            aantaLiterGetankt = byte.Parse(Console.ReadLine());
            //          HVL   liter heeft u over
            Console.WriteLine("hvl liter heeft u over");
            aantalLiterOver = byte.Parse(Console.ReadLine());

            // BEREKEN      ALS diesel
            //              DAN  SOM = 1,5900 * (getankt liter - liter over) totsom = som / aantal KM
            if (soort == Diesel)
            {
                som1 = (ushort)(aantaLiterGetankt - aantalLiterOver);
                som2 = (decimal)(1.5900 * som1);
                if (som2 > aantalKilometer)
                {
                    totsom = (decimal)(som2 / aantalKilometer);
                }
                else
                {
                    totsom = (decimal)(aantalKilometer / som2);
                }
                // TOON     de brandstof kost totsom
                Console.WriteLine($" uw brandstofkost is {totsom}EUR");
            }
            //              ALS super95
            //              DAN SOM = 1,5140 * (getankt liter - liter over) totsom = som / aantal KM
            if (soort == super95)
            {
                som1 = (ushort)(aantaLiterGetankt - aantalLiterOver);
                som2 = (ushort)(1.5140 * som1);
                if (som2 > aantalKilometer)
                {
                    totsom = (decimal)(som2 / aantalKilometer);
                }
                else
                {
                    totsom = (decimal)(aantalKilometer / som2);
                }
                    // TOON     de brandstof kost totsom
                    Console.WriteLine($" uw brandstofkost is {totsom} EUR");
            }
            //              ALS super97
            //              DAN SOM = 1,6020 * (getankt liter - liter over) totsom = som / aantal KM
            if (soort == super97)
            {
                som1 = (ushort)(aantaLiterGetankt - aantalLiterOver);
                som2 = (ushort)(1.6020 * som1);
                if (som2 > aantalKilometer)
                {
                    totsom = (decimal)(som2 / aantalKilometer);
                }
                else
                {
                    totsom = (decimal)(aantalKilometer / som2);
                }
                    // TOON     de brandstof kost totsom
                  Console.WriteLine($" uw brandstofkost is {totsom} EUR");
            }

            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
