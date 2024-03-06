using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AccessModifierPart2_HomeTask
{
    internal class City
    {
        //public City(string name, int population)
        //{
        //    Name = name;
        //    Population = population;
        //}

        public string Name {
            get
            {
                return _name;
            }

            set
            {
                int count = 0;
                //Name-in deyeri 3-20 araliginda olmalidir...
                foreach (var item in value)
                {
                    count++;
                }
                if (count > 3 && count < 20 && AreAllLetters(value))
                {
                    value = _name;
                }
                else
                {
                    Console.WriteLine("Name-Duzgun Daxil Edilmeyib!");
                }
                
                
            
            }
        }
        private string _name;

        public int Population {
            get
            {
                return _population;
            }


            set
            {
                if (value > 1000000)
                {
                    _population= value;
                }
                else
                {
                    Console.WriteLine("Population 0-dan kicik ola bilmez!");
                }
            }
        
        }
        private int _population;

        static bool AreAllLetters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
