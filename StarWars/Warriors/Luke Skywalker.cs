using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class Luke_Skywalker : Jedi
    {
        public override string Name { get; } = "Luke Skywalker";
        public override bool IsLightSide { get; } = true;

        public Luke_Skywalker(int power) : base(power)
        {
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

        public override void OnJoinBattle(BattleSimulator simulator)
        {
            foreach (var w in simulator.DarkSide.Warriors)
                if (w is Sith)
                    return;
            Morale = AvgPower();
        }
    }
}

