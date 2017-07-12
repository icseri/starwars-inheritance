using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Warriors
{
    class Yoda : Jedi
    {
        public Yoda(int power) : base(power)
        {
        }

        public override void OnJoinBattle(BattleSimulator simulator)
        {
           
        }

        public override void PostCombatEffect(BattleSimulator simulator)
        {
            
        }

        public override void PreCombatEffect(BattleSimulator simulator)
        {
            
        }

        public override void DecreasePower(BattleSimulator simulator, int power)
        {

            if (simulator.Chance(10))
                Power -= power / 2;
            else
                Power -= power;
        }

    }
}
