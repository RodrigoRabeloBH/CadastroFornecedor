using System;

namespace DevIO.Business.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public DateTime Created { get; set; }
        public bool IsActive { get; set; }

        // EF Relation
        public Provider Provider { get; set; }
        public Guid ProviderId { get; set; }
    }
}