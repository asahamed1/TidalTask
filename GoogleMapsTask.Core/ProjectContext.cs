using GoogleMapsTask.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleMapsTask.Core
{
   public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
       : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        
    }
        //entities
        public DbSet<UserLocation> UserLocation { get; set; }
    }
}
