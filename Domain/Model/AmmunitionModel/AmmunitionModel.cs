namespace Domain.Models
{
    public abstract class AmmunitionModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? ImageAddress { get; set; }
    }

}
