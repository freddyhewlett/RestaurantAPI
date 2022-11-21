﻿using Mango.Web.Models.Dto;

namespace Mango.Web.Services.Interfaces
{
    public interface ICartService
    {
        Task<T> GetCartByUserIdAsync<T>(string userId, string token = null);
        Task<T> AddToCartAsync<T>(CartDto cartDto, string token = null);
        Task<T> UpdateCartAsync<T>(CartDto cartDto, string token = null);
        Task<T> ApplyCoupon<T>(CartDto cartDto, string token = null);
        Task<T> RemoveFromCartAsync<T>(Guid cartId, string token = null);
        Task<T> RemoveCoupon<T>(string userId, string token = null);
    }
}
