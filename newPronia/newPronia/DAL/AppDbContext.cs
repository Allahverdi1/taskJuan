﻿using Microsoft.EntityFrameworkCore;
using newPronia.Models;

namespace newPronia.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
