namespace Domain.Models
{
    public abstract class AmmunitionModel
    {
        public virtual int Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual int Price { get; set; }
        public virtual string? ImageAddress { get; set; }
    }

}
