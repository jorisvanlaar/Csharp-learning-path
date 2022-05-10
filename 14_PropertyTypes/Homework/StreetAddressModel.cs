using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class StreetAddressModel
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public string HouseNumberFloor { get; set; }

        public StreetAddressModel(string streetName, int houseNumber, string houseNumberFloor)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
            HouseNumberFloor = houseNumberFloor;
        }
    }
}
