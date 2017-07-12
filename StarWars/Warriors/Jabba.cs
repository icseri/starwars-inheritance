using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class Jabba : Sith
    {
        public override string Name { get; } = "Jabba";
        public override bool IsLightSide { get; } = false;

        public Jabba(int power) : base(power)
        {
        }

        public override void OnLeaveBattle(BattleSimulator simulator)
        {
            
        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {
            if (simulator.Chance(50))
            {
                Power += 1;
                Console.WriteLine($"Jabba nagyon szerencsés, nőtt az ereje: {Power}");
            }
                        
            else
            {
                Console.WriteLine($"Jabba semmit nem tett a csapatért... :(");
            }
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {
            
        }
    }
}
