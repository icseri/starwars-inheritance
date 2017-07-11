using System.IO;

namespace StarWars
{
    static class FileHandler
    {
        const string WarriorsFileName = @"../../warriors.txt";

        public static Warrior[] ReadWarriors()
        {
            var data = File.ReadAllLines(WarriorsFileName);
            var warriors = new Warrior[data.Length];
            for (var i = 0; i < data.Length; i++)
                warriors[i] = Warrior.FromString(data[i]);
            return warriors;
        }
    }
}
