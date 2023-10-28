using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Entities
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CardId { get; set; }  // Foreign key to Card entity
        public Card? Card { get; set; }  // Navigation property to Card entity
        public int? RuleId { get; set; }  // Foreign key to Rule entity
        public Rule? Rule { get; set; }  // Navigation property to Rule entity
        public bool CanDispel {get;set;}
        public bool CanClean {get;set;}
        public bool WorksAgainstImmunity {get;set;}
        public decimal Growth {get;set;}
        public decimal SuccessRate {get;set;}
        public EffectType EffectType {get;set;}
        public EffectStat EffectStat {get;set;}
        public EffectScale EffectScale {get; set;}
        public Intention Intention {get;set;}
        public TriggerEvent TriggerEvent {get;set;}
        public DurationEffect DurationEffect {get;set;}
        public CastFrom CastFrom {get;set;}
    }

    public class AbilityConfiguration : IEntityTypeConfiguration<Ability>
    {
        public void Configure(EntityTypeBuilder<Ability> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(255);

            builder.HasOne(a => a.Card)
                .WithMany(c => c.Abilities)
                .HasForeignKey(a => a.CardId);
                .OnDelete(DeleteBehavior.SetNull);  // Optional: Set null on delete

            builder.Property(a => a.EffectType)
                .HasConversion<string>()
                .HasMaxLength(40);

            builder.Property(a => a.EffectStat)
                .HasConversion<string>()
                .HasMaxLength(40);

            builder.Property(a => a.EffectScale)
                .HasConversion<string>()
                .HasMaxLength(40);

            builder.Property(a => a.Intention)
                .HasConversion<string>()
                .HasMaxLength(40);

            builder.Property(a => a.TriggerEvent)
                .HasConversion<string>()
                .HasMaxLength(40);

            builder.Property(a => a.DurationEffect)
                .HasConversion<string>()
                .HasMaxLength(40);

            builder.Property(a => a.CastFrom)
                .HasConversion<string>()
                .HasMaxLength(40);

            builder.HasOne(a => a.Card)
                .WithMany(c => c.Abilities)
                .HasForeignKey(a => a.CardId);
        }
    }
}
