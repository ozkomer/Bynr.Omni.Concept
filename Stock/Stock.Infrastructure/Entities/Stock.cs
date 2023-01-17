using Bynr.Omni.Concept.Core.Entity;

namespace Stock.Infrastructure.Entities
{
    public class Stock : IEntity
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
