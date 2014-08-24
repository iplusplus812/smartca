using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCA.Domain
{
    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PostalCode { get; private set; }

        public Address(string street,string city,string state,string postalCode)
        {
            this.Street = street;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.Validate();
        }

        private void Validate()
        {
            if (string.IsNullOrEmpty(this.Street) ||
                string.IsNullOrEmpty(this.City) ||
                string.IsNullOrEmpty(this.State) ||
                string.IsNullOrEmpty(this.PostalCode))
            {
                throw new InvalidOperationException("无效地址");
            }
        }
    }
}
