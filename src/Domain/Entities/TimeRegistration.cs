﻿using Domain.Entities.Base;
using System;

namespace Domain.Entities
{
    public class TimeRegistration : BaseEntity
    {
        public string Week { get; set; }

        public double Hours { get; set; }

        public DateTime Day { get; set; }

        public DateTime CreatedAt { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int WorkerId { get; set; }

        public Worker Worker { get; set; }
    }
}