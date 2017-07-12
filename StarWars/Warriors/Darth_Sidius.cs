using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class Darth_Sidius : Warrior
    {
        public override string Name { get; } = "Darth Sidius";
        public override bool IsLightSide { get; } = true;

        public Darth_Sidius(int power) : base(power)
        {
        }
        public override void OnJoinBattle(BattleSimulator simulator)
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
            foreach (var w in simulator.LightSide.Warriors)
            {
                if (w.IsForceUser)
                    simulator.LightSide.Morale -= 1;
            }
            Console.WriteLine($"Az ellenfél új morálja: {simulator.LightSide.Morale}");
        }
    }
}
