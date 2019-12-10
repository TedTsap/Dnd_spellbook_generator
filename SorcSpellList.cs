using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndSpellbookGenerator
{
    class SorcSpellList
    {
        public List<Spell> SorcFirstLvlSpells { get; set; }


        List<Spell> firstLvlSpells = new List<Spell>()
        {
            new Spell("Burning Hands", 0.8),
            new Spell("Charm Person", 0.5),
            new Spell("Color Spray", 0.2),
            new Spell("Comprehend Languages", 0.3),
            new Spell("Detect Magic", 0.6),
            new Spell("Disguise Self", 0.6),
            new Spell("Expeditious Retreat", 0.3),
            new Spell("False Life", 0.4),
            new Spell("Feather Fall", 0.5),
            new Spell("Fog Cloud", 0.6),
            new Spell("Jump", 0.5),
            new Spell("Mage Armor", 0.7),
            new Spell("Magic Missile", 100),
            new Spell("Shield", 0.7),
            new Spell("Silent Image", 0.5),
            new Spell("Sleep", 0.9),
            new Spell("Thunderwave", 0.6),
        };
        public SorcSpellList()
        {
            SorcFirstLvlSpells = firstLvlSpells;
        }
    }
}
