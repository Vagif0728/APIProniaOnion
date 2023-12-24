namespace Pronia.Domain.Entities
{
    public class Tag : BaseNameableEntity
    {
        public ICollection<ProductTag> ProductTags { get; set; }
    }
}
