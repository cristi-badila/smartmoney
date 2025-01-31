﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;

namespace SmartMoneyJobRunner.Models
{
    public class Stop
    {
        public DbGeography Location { get; set; }
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public decimal Duration { get; set; }

        public virtual ICollection<PointOfInterest> PointsOfInterest { get; set; }

        public Stop()
        {
            Id = Guid.NewGuid();
        }
    }
}