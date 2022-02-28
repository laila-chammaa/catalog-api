using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record UpdateItemDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        [Range(0.0, Double.PositiveInfinity)]
        public decimal Price { get; init; }
    }
}