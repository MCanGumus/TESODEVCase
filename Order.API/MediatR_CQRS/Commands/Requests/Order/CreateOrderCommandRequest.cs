﻿using MediatR;
using Order.API.MediatR_CQRS.Commands.Responses.Order;

namespace Order.API.MediatR_CQRS.Commands.Requests.Order
{
    public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public Guid CustomerId { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public Guid ProductId { get; set; }
        public Guid AddressId { get; set; }
    }
}
