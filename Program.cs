using NewChallengeTwo_CSharp.Entities;
using System;
using System.Globalization;
using System.Linq;

namespace NewChallengeTwo_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start
            Console.WriteLine("UBUNTU 002 - STARS...");

            //Assigning List
            var ubuntus = Ubuntus.CreateList();

            //Sum ages from the list
            int SumOfAge = ubuntus.Sum(_ua => _ua.Age);

            //Print SUM of age ChallengeTwoTask001
            Console.WriteLine("\nA soma das idades é " + SumOfAge + "\n");

            //Print GROUP NAMES of age ChallengeTwoTask002
            Console.WriteLine(Ubuntus.GroupNames());

            //Print Average IBM ChallengeTwoTask003
            //IMC = Weight / (height x height)
            //Average = (IMC+IMC+IMC)/ubuntus.count            
            Console.WriteLine("Média de IMC = " + (ubuntus.Sum(_ub => _ub.Bmi)/ubuntus.Count)
                .ToString("F2", CultureInfo.InvariantCulture) + "Kg/m²\n");

            //Print dev count ChallengeTwoTask004
            Console.WriteLine("Possuí " + ubuntus.Where(_ud => _ud.IsDev).Count() + " devs no time!\n");

            //Print name that contains silva ChallengeTwoTask005
            Console.WriteLine(Ubuntus.VerifyNames());

            Console.WriteLine("\nUBUNTU: THE  BETTER YOU ARE THE BETTER I AM!");
            Console.WriteLine("\n\n\tVAMO DALE PARA NÂO TOMALE!\n\t\tVAMOS VIVER!\n\t\t\tNÃO APENAS SOBREVIVER!");


        }
    }
}
