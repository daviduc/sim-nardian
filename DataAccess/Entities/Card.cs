using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccess.Enums;
namespace DataAccess.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public int Melee { get; set; }
        public int Range { get; set; }
        public int Magic { get; set; }
        public int Speed { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public boolean IsGladiator {get;set;}
        public boolean IsSoulBound {get;set;}
        public League League {get;set;}
        public List<Ability> Abilities {get;set;}

    }

    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            // Your configuration here, for example:
            builder.HasKey(c => c.Id);  // Set primary key
            // builder.HasOne(...).WithMany(...);  // Example for navigational properties
        }
    }
}
