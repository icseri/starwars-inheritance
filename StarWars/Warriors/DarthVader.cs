using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class DarthVader : Sith
    {
        public override string Name { get; } = "DarthVader";
        public override bool IsLightSide { get; } = false;

        public DarthVader(int power) : base(power)
        {
        }

       
        
        public override bool IsStrongerThan(BattleSimulator simulator, Warrior other)
        {
            if (other is ForceUser)
                return base.IsStrongerThan(simulator, other);
            return Power + 3 > other.Power;

    

        }

        public override void OnLeaveBattle(BattleSimulator simulator)
        {

        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {

        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {

        }
    }
}



