using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Savings a floating-point number
            double savings = double.Parse(Console.ReadLine());
            // 2. Drumset numbers
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> drums = new List<int>();
            for (int i = 0; i < drumSet.Count; i++)
            {
                drums.Add(drumSet[i]);
            }
            // 3. Until command "Hit it again, Gabsy!" receiving hit power
            string command = Console.ReadLine();
            while (command != "Hit it again, Gabsy!")
            {
                // 4. Decreases every drum with hit power
                int power = int.Parse(command);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    if (drumSet[i] > 0)
                    {
                        drumSet[i] -= power;
                    }

                    // 5. When the drum reaches 0 or less it is replaced with a new one (the same in value), if there is no money it is removed from the set
                    if (drumSet[i] <= 0)
                    {
                        savings -= drums[i] * 3;
                        drumSet[i] = drums[i];
                        if (savings < 0)
                        {
                            savings += drums[i] * 3;
                            drumSet.Remove(drumSet[i]);
                            drums.Remove(drums[i]);
                            i--;
                        }

                    }

                }

                command = Console.ReadLine();
            }
            // 6. When I receive the command I stop the program and print 1st line drum set and on the 2nd remaining money
            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
