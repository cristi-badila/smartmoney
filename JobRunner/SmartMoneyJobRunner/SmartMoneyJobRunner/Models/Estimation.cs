﻿using System;

namespace SmartMoneyJobRunner.Models
{
    public class Estimation
    {
        public Guid StopId { get; set; }
        public decimal Amount { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid Id { get; set; }
        public Estimation()
        {
            Id = Guid.NewGuid();
        }
    }
}