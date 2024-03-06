using System.Security.Cryptography.X509Certificates;

namespace AccessModifierPart2_HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChineCity[] chineCities = new ChineCity[0];
            Array.Resize(ref chineCities, chineCities.Length + 1);


            int sum = 0;

            for (int i = 0; i <5; i++)
            {
                ChineCity ch = new ChineCity();
                Console.WriteLine("Seherin Adini Daxil Edin: ");
                ch.Name = Console.ReadLine();
                while(true)
                {
                    Console.Write("Population: ");
                    if (int.TryParse(Console.ReadLine(), out int population))
                    {
                        ch.Population=population;
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Yanlis Daxil Etdiniz. Yeniden ");
                    }
                }
                chineCities[i] = ch;                
            }
            double Avarage = AvarageOfPopulation();
        }
        public double AvarageOfPopulation(ChineCity [] chineCities)
        {
           
            double sum = 0;

            foreach (var item in chineCities)
            {
                sum = sum + (item.Population);
            }
            return(double) sum / 5;
        }
    }
}