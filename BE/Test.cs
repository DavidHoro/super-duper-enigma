using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Test
    {
        private static int Test_code = 10000000;
        private int Tester_ID { get; set; }
        private int Trainee_ID { get; set; }
        private DateTime Time { get; set; }
        private Address Starting_address { get; set; }
        private Criteria Safe_distance { get; set; }
        private Criteria Parking { get; set; }
        private Criteria Mirrors_observing { get; set; }
        private Criteria Signals { get; set; }
        private Criteria Priority { get; set; }
        private Criteria Expropriation_of_control { get; set; }
        private Criteria Status { get; set; }
        private string Remarks { get; set; }

        public override string ToString()
        {
            return Test_code + " " + Tester_ID + " " + Trainee_ID + " " + Status;
        }
    }
}
