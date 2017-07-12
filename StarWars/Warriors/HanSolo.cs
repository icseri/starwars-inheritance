using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class HanSolo : Warrior
    {
        public override string Name { get; } = "Han Solo";
        public override bool IsLightSide { get; } = true;

        public HanSolo(int power) : base(power)
        {
        }

        public override void OnJoinBattle(BattleSimulator simulator)
        {
            
        }

        public override void OnLeaveBattle(BattleSimulator simulator)
        {
            simulator.LightSide.HanSoloDied = true;
        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {
            
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {
            
        }
    }
}
