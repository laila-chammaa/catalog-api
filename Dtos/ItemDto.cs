using System;

namespace Catalog.Dtos
{
    public record ItemDto
    {
        public Guid Id { get; init; } // immutable prop without a constructor
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }

    }
}