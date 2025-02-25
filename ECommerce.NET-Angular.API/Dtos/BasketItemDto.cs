﻿using System.ComponentModel.DataAnnotations;

namespace ECommerce.NET_Angular.API.Dtos
{
    public class BasketItemDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [Range(0.1,double.MaxValue,ErrorMessage = "Fiyat Bilgisi İzin Verilen Aralıkta Olmalıdır")]
        public decimal Price { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Miktar Bilgisi İzin Verilen Aralıkta Olmalıdır")]
        public int Quantity { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
