using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Entities
{
    public class Rule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ability> Abilities { get; set; } = new List<Ability>();
    }

    public class RuleConfiguration : IEntityTypeConfiguration<Rule>
    {
        public void Configure(EntityTypeBuilder<Rule> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(255);

            builder.HasMany(r => r.Abilities)
                .WithOne(a => a.Rule)
                .HasForeignKey(a => a.RuleId)
                .OnDelete(DeleteBehavior.SetNull);  // Optional: Set null on delete
        }
    }
}
