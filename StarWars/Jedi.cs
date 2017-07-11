namespace StarWars
{
    abstract class Jedi : ForceUser
    {
        protected Jedi(int power) : base(power)
        {
        }

        public override void OnLeaveBattle(BattleSimulator simulator)
        {
            simulator.LightSide.Morale += 5;
        }
    }
}
