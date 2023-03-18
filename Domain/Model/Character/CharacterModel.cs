using Domain.GameCharacter;
using Domain.Model.Character;
using Domain.Model.HitPointModel;

namespace Domain.Models
{
    public class CharacterModel
    {
        public virtual int Id { get; set; } = 0;
        public virtual string? Name { get; set; }
        public virtual double Life { get; set; } = 0;
        public virtual double Attack { get; set; } = 0;
        public virtual double Defence { get; set; } = 0;
        public virtual CharacterRaceEnum? CharacterRace { get; set; }
        public virtual LevelModel? Level { get; set; }
        public virtual ShieldModel? Shield { get; set; }
        public virtual List<WeaponModel>? Weapon { get; set; }
        public virtual List<ArmorModel>? Armor { get; set; }
        public virtual string? ImageAddress { get; set; }
    }
}
