using FroomBikes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FroomBikes.AppDbContext
{
    public class FroomDbContext: DbContext
    {
        public FroomDbContext(DbContextOptions<FroomDbContext> options): base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}
