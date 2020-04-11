using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabctoryPattern
{
    public interface ArmyFactory
    {
        Healer createHealer();
        DamageDealer createDD();
        Tank createTank();
        SpellCaster createSpellCaster();
    }
}
