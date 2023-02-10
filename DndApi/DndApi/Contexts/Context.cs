using DndApi.Entitys;
using DndApi.Entitys.JoinTables;
using Microsoft.EntityFrameworkCore;

namespace DndApi.Contexts
{
    public class Context : DbContext
    {
        public DbSet<ArmorEntity> Armors { get; set; }
        public DbSet<ClassEntity> Classes { get; set; }
        public DbSet<EquipmentEntity> Equipment { get; set; }
        public DbSet<PlayerEntity> Players { get; set; }
        public DbSet<RaceEntity> Races { get; set; }
        public DbSet<SkillEntity> Skills { get; set; }
        public DbSet<WeaponEntity> Weapons { get; set; }


        //jointables
        public DbSet<PlayerSkillsEntity> PlayerSkills { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EquipmentEntity>()
                .HasOne(e => e.Head)
                .WithOne()
                .HasForeignKey<EquipmentEntity>(e => e.HeadId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EquipmentEntity>()
                .HasOne(e => e.Sholder)
                .WithOne()
                .HasForeignKey<EquipmentEntity>(e => e.SholderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EquipmentEntity>()
                .HasOne(e => e.Chest)
                .WithOne()
                .HasForeignKey<EquipmentEntity>(e => e.ChestId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EquipmentEntity>()
                .HasOne(e => e.Hands)
                .WithOne()
                .HasForeignKey<EquipmentEntity>(e => e.HandsId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EquipmentEntity>()
                .HasOne(e => e.Legs)
                .WithOne()
                .HasForeignKey<EquipmentEntity>(e => e.LegsId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EquipmentEntity>()
                .HasOne(e => e.Feet)
                .WithOne()
                .HasForeignKey<EquipmentEntity>(e => e.FeetId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
