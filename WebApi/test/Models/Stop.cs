﻿using System;
using System.Data.Entity.Spatial;

namespace test.Models
{
    public class Stop
    {
        public DbGeography Location { get; set; }
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public decimal Duration { get; set; }
        public Stop()
        {
            Id = Guid.NewGuid();
        }
    }
}