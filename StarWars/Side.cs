using System;

namespace StarWars
{
    class Side
    {
        readonly static Random _rand = new Random();
        public Warrior[] Warriors;
        Warrior _current;

        public int Morale { get; set; }
        public bool HanSoloDied { get; set; }


        public Side(Warrior[] warriors, bool isLightSide)
        {
            Warriors = new Warrior[CountOfSide(warriors, isLightSide)];
            var index = 0;
            foreach (var w in warriors)
                if (w.IsLightSide == isLightSide)
                    Warriors[index++] = w;
            Morale = AvgPower();
            Console.WriteLine($"A {(isLightSide ? "jó" : "rossz")} oldal készen áll.");
        }

        public Warrior GetWarrior(BattleSimulator simulator)
        {
           
            var result = _current ?? (_current = GetRandomWarrior());
            if (HanSoloDied)
            {
                HanSoloDied = false;
                if (_current.Name == "Luke Skywalker")
                    _current.DecreasePower(simulator, -5);
            }
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
            foreach (var warrior in Warriors)
                if (warrior != null)
                    sum += warrior.Power;
            return sum / Warriors.Length;
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
            while (i < Warriors.Length && Warriors[i] == null)
                i++;
            if (i == Warriors.Length)
                return null;

            var index = _rand.Next(i, Warriors.Length);
            while (Warriors[index] == null)
                index = _rand.Next(i, Warriors.Length);
            var result = Warriors[index];
            Warriors[index] = null;
            Console.WriteLine($"{result.Name} csatlakozik a csatába");
            return result;
        }
    }
}
