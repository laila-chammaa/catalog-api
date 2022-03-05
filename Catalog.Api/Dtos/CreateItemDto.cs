using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Api.Dtos
{
    public record CreateItemDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        [Range(0.0, Double.PositiveInfinity)]
        public decimal Price { get; init; }
    }
}