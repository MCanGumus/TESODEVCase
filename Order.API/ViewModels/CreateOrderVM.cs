﻿namespace Order.API.ViewModels
{
    public class CreateOrderVM
    {
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public Guid AddressId { get; set; }
        public int Count {  get; set; }
        public decimal Price {  get; set; }

    }
}
