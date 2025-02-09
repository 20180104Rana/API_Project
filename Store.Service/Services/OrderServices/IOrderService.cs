﻿using Store.Data.Entities;
using Store.Service.Services.OrderServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Services.OrderServices
{
    public interface IOrderService
    {
        Task<OrderDetailsDto> CreateOrderAsync(OrderDto input);
        Task<IReadOnlyList<OrderDetailsDto>> GetAllOrdersForUserAsync(string buyerEmail);
        Task<OrderDetailsDto> GetOrderByIdAsync(Guid id);
        Task<IReadOnlyList<DeliverMethod>> GetAllDeliveryMethodAsync(Guid id);


    }
}