namespace StarWars
{
    abstract class ForceUser : Warrior
    {
        protected ForceUser(int power) : base(power)
        {
        }

        public override bool IsForceUser { get; } = true;
        public override bool IsStrongerThan(BattleSimulator simulator, Warrior other)
        {
            if (other is ForceUser)
                return base.IsStrongerThan(simulator, other);
            return Power + 2 > other.Power;
        }
    }
}
