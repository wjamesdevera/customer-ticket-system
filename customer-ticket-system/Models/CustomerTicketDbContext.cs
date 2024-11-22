using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace customer_ticket_system.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CustomerTicketDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles {  get; set; }
        //public DbSet<Ticket> Tickets { get; set; }
        //public DbSet<Label> Labels { get; set; }
        //public DbSet<Comment> Comments { get; set; }

        public CustomerTicketDbContext(): base() { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleId);
        }
    }
}