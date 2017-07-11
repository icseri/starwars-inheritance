namespace StarWars
{
    abstract class Sith : ForceUser
    {
        protected Sith(int power) : base(power)
        {
        }

        public override void OnJoinBattle(BattleSimulator simulator)
        {
            simulator.LightSide.Morale -= 5;
        }
    }
}
