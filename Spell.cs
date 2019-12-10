using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndSpellbookGenerator
{
    class Spell
    {
        public string Name { get; set; }
        public double Coefficient { get; set; }

        public Spell(string name, double coefficient)
        {
            Name = name;
            Coefficient = coefficient;
        }
    }
}
