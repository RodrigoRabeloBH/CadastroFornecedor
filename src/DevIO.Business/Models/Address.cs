using System;

namespace DevIO.Business.Models
{
    public class Address : Entity
    {
        public string Zipcode { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        // EF Relation
        public Provider Provider { get; set; }
        public Guid ProviderId { get; set; }

    }
}