using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewChallengeTwo_CSharp.Entities
{
    public class Ubuntus
    {

        //Class properties, here!
        #region classProperties
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public decimal Height { get; set; }
        public decimal Bmi { get; set; }
        public bool IsDev { get; set; }
        #endregion

        //Constructor (go to Google)
        #region Constructor
        public Ubuntus()
        {
        }
        public Ubuntus(string name, int age, double weight, decimal height, bool isDev)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            IsDev = isDev;
            Bmi = (decimal)weight / (height * height);
        }
        #endregion

        //Class methods/functions

        #region Methods/Functions
        public static List<Ubuntus> CreateList()
        {
            //Object instance
            var ubuntus = new List<Ubuntus>();

            //Creating list
            ubuntus.Add(new Ubuntus("Ubuntu silva", 33,88.50,1.65M,true));
            ubuntus.Add(new Ubuntus("Ubuntu Santos", 26, 84.50, 2.10M, true));
            ubuntus.Add(new Ubuntus("Ubuntu3 Silva", 85, 66.50, 1.40M, false));


            return ubuntus;
        }

        public static string GroupNames()
        {
            string groupNames = "Os nome são:\n";
            var ubuntus = CreateList();
            foreach(var ubuntu in ubuntus)
            {
                groupNames += "\t*" + ubuntu.Name + "\n";
            }
            return groupNames;
        }

        public static string VerifyNames()
        {
            string groupNames = "Os Silvas: \n";
            var ubuntus = CreateList();
            foreach (var ubuntu in ubuntus)
            {
                //TOUPPER = avoid sensitive case
                if (ubuntu.Name.ToUpper().Contains("siLvA".ToUpper()))
                {
                    groupNames += "\t*" + ubuntu.Name + "\n";
                }
                
            }
            return groupNames;
        }
        #endregion
    }
}
