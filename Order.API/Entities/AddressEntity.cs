﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Order.API.Entities
{
    public class AddressEntity
    {
        [Key]
        public Guid AddressId { get; set; }
        public string? AddressLine { get; set; }
        public required string  City{ get; set; }
        public required string Country { get; set; }
        public required string CityCode{ get; set; }

        ICollection<OrderEntity> Orders { get; set; }
    }
}
