using System;

namespace StarWars
{
    class BattleSimulator
    {
        public Side LightSide { get; }
        public Side DarkSide { get; }

        public BattleSimulator(Warrior[] warriors)
        {
            LightSide = new Side(warriors, true);
            DarkSide = new Side(warriors, false);
            Console.WriteLine("Szimuláció indítása...");
        }

        public Warrior RunSimulation()
        {
            Warrior light = null, dark = null;
            while ((light = LightSide.GetWarrior(this)) != null &&
                   (dark = DarkSide.GetWarrior(this)) != null)
            {
                light.PreCombatEffect(this);
                dark.PreCombatEffect(this);
                if (light.IsStrongerThan(this, dark))
                {
                    light.DecreasePower(this, dark.Power);
                    if (light.Power <= 0)
                        LightSide.KillWarrior(this);
                    DarkSide.KillWarrior(this);
                }
                else if (dark.IsStrongerThan(this, light))
                {
                    dark.DecreasePower(this, light.Power);
                    if (dark.Power <= 0)
                        DarkSide.KillWarrior(this);
                    LightSide.KillWarrior(this);
                }
                else
                {
                    LightSide.KillWarrior(this);
                    DarkSide.KillWarrior(this);
                }
                light.PostCombatEffect(this);
                dark.PostCombatEffect(this);
            }

            return light ?? dark;
        }

        static readonly Random _rand = new Random();
        public bool Chance(int percent)
        {
            return _rand.Next(1, 101) <= percent;
        }
    }
}
