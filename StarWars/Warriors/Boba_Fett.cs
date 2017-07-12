using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class Boba_Fett : Warrior
    {
        public override string Name { get; } = "Boba Fett";
        public override bool IsLightSide { get; } = true;

        public Boba_Fett(int power) : base(power)
        {
        }
        public override void OnJoinBattle(BattleSimulator simulator)
        {
            if (simulator.LightSide.Morale < simulator.DarkSide.Morale)
            {
                simulator.DarkSide.Morale += 2;
                Console.WriteLine($"A csapata új morálja: {simulator.DarkSide.Morale}");
            }         
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
