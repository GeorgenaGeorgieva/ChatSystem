using ChatSystem.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChatSystem.Data
{
    public class ChatSystemDbContext : IdentityDbContext<User>
    {
        public ChatSystemDbContext(DbContextOptions<ChatSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        public override DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Message>()
                .HasOne(e => e.User)
                .WithMany(e => e.Messages)
                .HasForeignKey(e => e.UserId);
 

            base.OnModelCreating(builder);
        }
    }
}
