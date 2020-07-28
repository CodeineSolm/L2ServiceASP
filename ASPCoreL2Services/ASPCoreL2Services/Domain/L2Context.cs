using ASPCoreL2Services.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCoreL2Services.Domain
{
    public class L2Context : DbContext
    {
        public L2Context(DbContextOptions<L2Context> options) : base(options) { }
        public DbSet<EntityBase> DBEntityBase { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EntityBase>().HasData(
                new EntityBase { Id = 1, Title = "Adena", Subtitle = "Equip your character fast to compete", 
                    Description = "Buy adena instantly, we have unlimited amount of gold.", 
                    Preview = "images/adena.jpg", 
                    Subpreview = "images/equip1.jpg, images/equip2.jpg, images/equip3.jpg", 
                    Price = 6, DateAdded = DateTime.UtcNow },

                new EntityBase { Id = 2, Title = "Experience", Subtitle = "You need high level for endgame.",
                    Description = "Fastest exp u ever seen.", 
                    Preview = "images/exp.jpg", 
                    Subpreview = "images/endgame1.jpg, images/endgame2.jpg, images/endgame3.jpg", 
                    Price = 6, DateAdded = DateTime.UtcNow },

                new EntityBase { Id = 3, Title = "Quests", Subtitle = "If u dont have time to do quests", 
                    Description = "40k, 80k, 100k mobs is boring.", 
                    Preview = "images/quests.jpg", 
                    Subpreview = "images/quest1.jpg, images/quest2.jpg, images/quest3.jpg", 
                    Price = 6, DateAdded = DateTime.UtcNow }
                );
        }
    }
}
