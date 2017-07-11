using System;

namespace StarWars.Warriors
{
    class JarJar : Warrior
    {
        public override string Name { get; } = "Jar Jar";
        public override bool IsLightSide { get; } = true;

        public JarJar(int power) : base(power)
        {
        }

        /// <summary>
        /// 5% eséllyel növeli csapata morálját 20 egységgel, 
        /// ha ez nem sikerül akkor további 20% esélye van 5-el növelni azt.
        /// </summary>
        /// <param name="simulator">Simulator.</param>
        public override void OnJoinBattle(BattleSimulator simulator)
        {
            if (simulator.Chance(5))
            {
                simulator.LightSide.Morale += 20;
                Console.WriteLine($"Jar Jar nagyon szerencsés, csapata új morálja: {simulator.LightSide.Morale}");
            }
            else if (simulator.Chance(20))
            {
                simulator.LightSide.Morale += 5;
                Console.WriteLine($"Jar Jar szerencsés, csapata új morálja: {simulator.LightSide.Morale}");
            }
            else
            {
                Console.WriteLine($"Jar Jar semmit nem tett a csapatért...");
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
