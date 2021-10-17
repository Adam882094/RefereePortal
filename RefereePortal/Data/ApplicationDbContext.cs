using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RefereePortal.Models;

namespace RefereePortal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Game> Games { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
