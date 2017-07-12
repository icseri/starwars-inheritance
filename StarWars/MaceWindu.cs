using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class MaceWindu : Jedi
    {
        public override string Name { get; } = "Mace Windu";
        public override bool IsLightSide { get; } = true;

        public MaceWindu(int power) : base (power)
        {

        }

        public override void OnJoinBattle(BattleSimulator simulator)
        {
         
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {
     
        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {
       
        }

        public override void OnLeaveBattle(BattleSimulator simulator)
        {
            var opponent = simulator
                .DarkSide // or light side
                .GetWarrior(simulator);
            if (Power <= 0 && opponent.Power > 0) // vagy power ==0?
                opponent.DecreasePower(simulator, 1);
        }
    }
}
