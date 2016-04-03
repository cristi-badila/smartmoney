using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;

namespace SmartMoneyJobRunner.Models
{
    public class PointOfInterest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DbGeography Location { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Stop> Stops { get; set; }

        public PointOfInterest()
        {
            Id = Guid.NewGuid();
            Categories = new List<Category>();
            Stops = new List<Stop>();
        }
    }
}