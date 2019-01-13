using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Spital.Models
{
    public class SpitalContext:DbContext
    {
        public SpitalContext() : base("SpitalDB3")
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<Tratament> Trataments { get; set; }
    }
}