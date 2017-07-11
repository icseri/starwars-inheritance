using System;

namespace StarWars
{
    class Side
    {
        readonly static Random _rand = new Random();
        readonly Warrior[] _warriors;
        Warrior _current;

        public int Morale { get; set; }

        public Side(Warrior[] warriors, bool isLightSide)
        {
            _warriors = new Warrior[CountOfSide(warriors, isLightSide)];
            var index = 0;
            foreach (var w in warriors)
                if (w.IsLightSide == isLightSide)
                    _warriors[index++] = w;
            Morale = AvgPower();
            Console.WriteLine($"A {(isLightSide ? "jó" : "rossz")} oldal készen áll.");
        }

        public Warrior GetWarrior(BattleSimulator simulator)
        {
            var result = _current ?? (_current = GetRandomWarrior());
            result?.OnJoinBattle(simulator);
            return result;
        }

        public void KillWarrior(BattleSimulator simulator)
        {
            _current.OnLeaveBattle(simulator);
            Console.WriteLine($"{_current.Name} kiesett");
            _current = null;
        }

        public int AvgPower()
        {
            var sum = 0;
            foreach (var warrior in _warriors)
                if (warrior != null)
                    sum += warrior.Power;
            return sum / _warriors.Length;
        }

        int CountOfSide(Warrior[] warriors, bool side)
        {
            var count = 0;
            foreach (var w in warriors)
                if (w.IsLightSide == side)
                    count++;
            return count;
        }

        Warrior GetRandomWarrior()
        {
            var i = 0;
            while (i < _warriors.Length && _warriors[i] == null)
                i++;
            if (i == _warriors.Length)
                return null;

            var index = _rand.Next(i, _warriors.Length);
            while (_warriors[index] == null)
                index = _rand.Next(i, _warriors.Length);
            var result = _warriors[index];
            _warriors[index] = null;
            Console.WriteLine($"{result.Name} csatlakozik a csatába");
            return result;
        }
    }
}
