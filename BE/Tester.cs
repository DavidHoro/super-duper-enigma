using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester
    {
        private int ID { get; set; }
        private string Last_Name { get; set; }
        private string First_Name { get; set; }
        private Date Date_Of_Birth { get; set; }
        private Gender gender { get; set; }
        private string Phone_Number { get; set; }
        private Address address { get; set; }
        private int Seniority { get; set; }
        private int Max_Test { get; set; }
        private Vehicle Vehicle_Specialit { get; set; }
        private Gearbox Gear_Speciality { get; set; }
        private bool[,] Schedule { get; set; }
        private float Max_Distance { get; set; }


        public override string ToString()
        {
            return First_Name + " " + Last_Name + " " + ID;
        }

    }
}
