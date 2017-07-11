using System;
using System.Threading;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMenu();
        }

        static void StartMenu()
        {
            string cmd = null;
            do
            {
                Console.Clear();
                Console.WriteLine("---Awesome starwars simulation---");
                Console.Write("1: Szimuláció\n2:Kilépés a programból\nParancs: ");
                cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "1":
                        var warriors = FileHandler.ReadWarriors();
                        var simulator = new BattleSimulator(warriors);
                        var winner = simulator.RunSimulation();
                        Console.WriteLine("Csata eredménye:");
                        if (winner == null)
                            Console.WriteLine("Döntetlen");
                        else
                            Console.WriteLine($"A {(winner.IsLightSide ? "jók" : "rosszak")} nyertek, utolsó harcos: {winner.Name}, megmaradt ereje: {winner.Power}");
                        Console.WriteLine("\n\n\nÜss le egy billentyűt a folytatáshoz...");
                        Console.ReadKey();
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Hibás parancs...");
                        Thread.Sleep(500);
                        break;
                }

            } while (true);
        }
    }
}
