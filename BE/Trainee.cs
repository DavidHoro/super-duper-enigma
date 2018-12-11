using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee
    {
        private int ID { get; set; }
        private string Last_Name { get; set; }
        private string First_Name { get; set; }
        private Date Date_Of_Birth { get; set; }
        private Gender gender { get; set; }
        private string Phone_Number { get; set; }
        private Address address { get; set; }
        private Vehicle Vehicle_Study { get; set; }
        private Gearbox Gear_Study { get; set; }
        private String School { get; set; }
        private String Teacher { get; set; }
        private int Lessons { get; set; }

        public override string ToString()
        {
            return First_Name + " " + Last_Name + " " + ID;
        }

    }
}
