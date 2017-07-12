using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class ObiWanKenobi : Jedi
    {
        public override string Name { get; } = "Obi Wan Kenobi";
        public override bool IsLightSide { get; } = true;

        public ObiWanKenobi(int power) :base(power)
        {

        }

        public override void OnJoinBattle(BattleSimulator simulator)
        {           
            foreach (var darkSide in simulator.DarkSide.Warriors)
                if (! (darkSide is Sith))
                    return;
            Power += 2;
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {
        
        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {
        
        }


    }
}
