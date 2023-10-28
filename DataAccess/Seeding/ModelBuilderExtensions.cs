using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;

namespace DataAccess.Seeding
{
    public static class ModelBuilderExtensions
    {
        public static void SeedAbilities(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>().HasData(
                new Ability { Id =1, Name = "Affliction",CanDispel=false,CanClean=true,WorksAgainstImmunity=false },
                new Ability { Id =2, Name = "Amplify",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =3, Name = "Armored Strike",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =4, Name = "Backfire",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =5, Name = "Blast",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =6, Name = "Blind",CanDispel=false,CanClean=true,WorksAgainstImmunity=false },
                new Ability { Id =7, Name = "Bloodlust",CanDispel=true,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =8, Name = "Camouflage",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =9, Name = "Cleanse",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =10, Name = "Close Range",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =11, Name = "Conscript",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =12, Name = "Corrosive Ward",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =13, Name = "Cripple",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =14, Name = "Deathblow",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =15, Name = "Demoralize",,CanDispel=false,CanClean=true,WorksAgainstImmunity=false },
                new Ability { Id =16, Name = "Dispel",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =17, Name = "Divine Shield",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =18, Name = "Dodge",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =19, Name = "Double Strike",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =20, Name = "Enrage",CanDispel=true,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =21, Name = "Flank",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =22, Name = "Flying",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =23, Name = "Forcefield",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =24, Name = "Fury",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =25, Name = "Giant Killer",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =26, Name = "Halving",CanDispel=false,CanClean=true,WorksAgainstImmunity=false },
                new Ability { Id =27, Name = "Headwinds",CanDispel=false,CanClean=true,WorksAgainstImmunity=false },
                new Ability { Id =28, Name = "Heal",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =29, Name = "Immunity",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =30, Name = "Inspire",CanDispel=true,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =31, Name = "Knock Out",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =32, Name = "Last Stand",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =33, Name = "Life Leech",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =34, Name = "Lookout",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =35, Name = "Magic Reflect",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =36, Name = "Martyr",CanDispel=true,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =37, Name = "Opportunity",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =38, Name = "Oppress",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =39, Name = "Phase",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =40, Name = "Piercing",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =41, Name = "Poison",CanDispel=false,CanClean=true,WorksAgainstImmunity=false },
                new Ability { Id =42, Name = "Protect",CanDispel=true,CanClean=false,WorksAgainstImmunity=true  },
                new Ability { Id =43, Name = "Reach",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =44, Name = "Rebirth",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =45, Name = "Recharge",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =46, Name = "Redemption",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =47, Name = "Reflection Shield",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =48, Name = "Repair",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =49, Name = "Resurrect",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =50, Name = "Retaliate",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =51, Name = "Return Fire",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =52, Name = "Rust",CanDispel=false,CanClean=true,WorksAgainstImmunity=false },
                new Ability { Id =53, Name = "Scattershot",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =54, Name = "Scavenger",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =55, Name = "Shatter",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =56, Name = "Shield",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =57, Name = "Silence",CanDispel=false,CanClean=true,WorksAgainstImmunity=false },
                new Ability { Id =58, Name = "Slow",CanDispel=false,CanClean=true,WorksAgainstImmunity=false},
                new Ability { Id =59, Name = "Snare",CanDispel=false,CanClean=true,WorksAgainstImmunity=true },
                new Ability { Id =60, Name = "Sneak",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =61, Name = "Snipe",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =62, Name = "Strengthen",CanDispel=true,CanClean=false,WorksAgainstImmunity=true },                
                new Ability { Id =63, Name = "Stun",CanDispel=false,CanClean=true,WorksAgainstImmunity=false },
                new Ability { Id =64, Name = "Swiftness",CanDispel=true,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =65, Name = "Tank Heal",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =66, Name = "Taunt",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =67, Name = "Thorns",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =68, Name = "Trample",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =69, Name = "Triage",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =70, Name = "True Strike",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =71, Name = "Void",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =72, Name = "Void Armor",CanDispel=false,CanClean=false,WorksAgainstImmunity=true },
                new Ability { Id =73, Name = "Weaken",CanDispel=false,CanClean=true,WorksAgainstImmunity=false },
                new Ability { Id =74, Name = "Weapons Training",CanDispel=true,CanClean=false,WorksAgainstImmunity=true },
                // ... other abilities

            );
        }

        // ... other seeding methods for other entities if needed
    }
}