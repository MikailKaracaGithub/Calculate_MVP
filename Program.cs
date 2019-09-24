using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_MVP
{
    class Program
    {
        static void Main(string[] args)
        {
            int avatar1BaseHP = 100;
            int avatar1capeHP = 40;
            int ringHP = 50;

            int totalBaseHP = avatar1BaseHP;
            int totalArmourHP = avatar1capeHP + ringHP;
            int totalHP = totalBaseHP + totalArmourHP;

            //Situation 1

            Console.WriteLine("Avatar 1, situation 1: " + totalHP);

            //Situation 2

            int gauntletHP = 33;
            totalArmourHP += gauntletHP;
            totalHP = totalBaseHP + totalArmourHP;
            Console.WriteLine("Avatar 1, situation 1: " + totalHP);

            //Situation 3

            totalBaseHP *= 2;
            totalHP = totalBaseHP + totalArmourHP;
            Console.WriteLine("Avatar 1, situation 1: " + totalHP);

            //Situation 4

            totalArmourHP *= 3;
            totalHP = totalBaseHP + totalArmourHP;
            Console.WriteLine("Avatar 1, situation 1: " + totalHP);

            Console.ReadLine();
        }
    }
}