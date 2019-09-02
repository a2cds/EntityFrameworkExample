using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EntityFrameworkExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    PersonId = 1,
                    FirstName = "Tara",
                    LastName = "Brewer",
                    City = "São Paulo",
                    Address = "Rua Piratininga, 202"
                },
                new Person
                {
                    PersonId = 2,
                    FirstName = "Andrew",
                    LastName = "Tippett",
                    City = "Rio de Janeiro",
                    Address = "Rua Carioca, 402"
                }
                );
        }

    }
}
