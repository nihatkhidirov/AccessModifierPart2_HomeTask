using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierPart2_HomeTask
{
    internal class ChineCity : City
    {
        public new int Population
        {
            get { return base.Population; }
            set
            {
                if (value >= 1000000)
                {
                    base.Population = value;
                }
                else
                {
                    Console.WriteLine("1000000-den Cox Olmalidir!");
                }
            }
        }
    }
}
