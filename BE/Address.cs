using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Address
    {
        private String street;
        private int building;
        private string city;

        public string Street { get => street; set => street = value; }
        public int Building { get => building; set => building = value; }
        public string City { get => city; set => city = value; }

        public Address(string s, int b, string c)
        {
            street = s;
            building = b;
            city = c;
        }
    }
}
