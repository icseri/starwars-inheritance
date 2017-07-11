using System;
using StarWars.Warriors;

namespace StarWars
{
    abstract class Warrior
    {
        /// <summary>
        /// Ez a függvény a fájlból beolvasott string alapján példányosít egy 
        /// megfelelő ObiWan, JarJar, DarthMaul, stb példányt, és azt visszadja.
        /// </summary>
        /// <returns>A létrehozott warrior példányt</returns>
        /// <param name="s">A beolvasott fájl egy sora</param>
        public static Warrior FromString(string s)
        {
            var data = s.Substring(1).Split('#');
            var name = data[0].Replace('_', ' ');
            var power = int.Parse(data[1]);
            switch (name)
            {
                //TODO további warrior példányosítások itt.
                case "Jar Jar":
                    return new JarJar(power);
            }
            return null;
        }

        public int Power { get; protected set; }
        public virtual string Name { get; }
        public virtual bool IsLightSide { get; }
        public virtual bool IsForceUser { get; }

        protected Warrior(int power)
        {
            Power = power;
        }

        public abstract void OnJoinBattle(BattleSimulator simulator);
        public abstract void OnLeaveBattle(BattleSimulator simulator);
        public abstract void PreCombatEffect(BattleSimulator simulator);
        public abstract void PostCombatEffect(BattleSimulator simulator);
        public virtual void DecreasePower(BattleSimulator simulator, int power)
        {
            Power -= power;
        }

        public virtual bool IsStrongerThan(BattleSimulator simulator, Warrior other)
        {
            var side = IsLightSide ? simulator.LightSide : simulator.DarkSide;
            var otherSide = side == simulator.LightSide ? simulator.DarkSide : simulator.LightSide;
            var ownPower = (1.0 + (side.Morale / 100.0)) * Power;
            var otherPower = (1.0 + (otherSide.Morale / 100.0)) * other.Power;
            Console.WriteLine($"{Power} erő összehasonlítása {side.Morale} morállal ({ownPower}), ellenfél: {other.Power} erő {otherSide.Morale} morállal ({otherPower})");
            return ownPower > otherPower;
        }
    }
}
