using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class AddressModel
    {
        public StreetAddressModel StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string FullAddress
        {
            get 
            { 
                return $"{StreetAddress.StreetName} {StreetAddress.HouseNumber}-{StreetAddress.HouseNumberFloor}, {City} {State}, {ZipCode}"; 
            }
        }


        public AddressModel(StreetAddressModel streetAddress, string city, string state, string zipCode)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
