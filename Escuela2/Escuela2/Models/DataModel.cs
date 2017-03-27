using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace Escuela2.Models
{
    public class DataModel:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
        public DataModel() : base("DataModel")
        {

        }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}