using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var heroHP = new Dictionary<string, int>();
            var heroMP = new Dictionary<string, int>();

            AddHeroToTheParty(n, heroHP, heroMP);

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string currentCommand = command.Split(" - ")[0];
                string currHeroName = command.Split(" - ")[1];
                int currHeroMP = heroMP[currHeroName];

                switch (currentCommand)
                {
                    case "CastSpell":
                        int MPNeeded = int.Parse(command.Split(" - ")[2]);
                        string spellName = command.Split(" - ")[3];

                        if (currHeroMP >= MPNeeded)
                        {
                            heroMP[currHeroName] -= MPNeeded;
                            Console.WriteLine($"{currHeroName} has successfully cast {spellName} and now has {heroMP[currHeroName]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{currHeroName} does not have enough MP to cast {spellName}!");
                        }
                        break;

                    case "TakeDamage":
                        int damage = int.Parse(command.Split(" - ")[2]);
                        string attacker = command.Split(" - ")[3];

                        heroHP[currHeroName] -= damage;

                        if (heroHP[currHeroName] > 0)
                        {
                            Console.WriteLine($"{currHeroName} was hit for {damage} HP by {attacker} and now has {heroHP[currHeroName]} HP left!");
                        }
                        else
                        {
                            heroHP.Remove(currHeroName);
                            heroMP.Remove(currHeroName);
                            Console.WriteLine($"{currHeroName} has been killed by {attacker}!");
                        }
                        break;

                    case "Recharge":
                        int amountMP = int.Parse(command.Split(" - ")[2]);

                        if ((heroMP[currHeroName] + amountMP) >= 200)
                        {
                            Console.WriteLine($"{currHeroName} recharged for {200 - (heroMP[currHeroName])} MP!");
                            heroMP[currHeroName] = 200;
                        }
                        else
                        {
                            heroMP[currHeroName] += amountMP;
                            Console.WriteLine($"{currHeroName} recharged for {amountMP} MP!");
                        }


                        break;

                    case "Heal":
                        int amountHP = int.Parse(command.Split(" - ")[2]);

                        if ((heroHP[currHeroName] + amountHP) >= 100)
                        {
                            Console.WriteLine($"{currHeroName} healed for {100 - (heroHP[currHeroName])} HP!");
                            heroHP[currHeroName] = 100;
                        }
                        else
                        {
                            heroHP[currHeroName] += amountHP;
                            Console.WriteLine($"{currHeroName} healed for {amountHP} HP!");
                        }

                        break;
                }
            }

            var items = heroHP.OrderByDescending(r => r.Value).ThenBy(r => r.Key);

            foreach (var kvp in items)
            {
                

                Console.WriteLine(kvp.Key);
                Console.WriteLine($"  HP: {kvp.Value}");
                Console.WriteLine($"  MP: {heroMP[kvp.Key]}");
            }
        }

        static void AddHeroToTheParty(int n, Dictionary<string, int> heroHP, Dictionary<string, int> heroMP)
        {
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                string currHeroName = input[0];
                int currHeroHP = int.Parse(input[1]);
                int currHeroMP = int.Parse(input[2]);


                if (!heroHP.ContainsKey(currHeroName))
                {
                    heroHP[currHeroName] = currHeroHP;
                    heroMP[currHeroName] = currHeroMP;
                }
            }
        }
    }
}
