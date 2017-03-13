using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class Parcial2Db : DbContext
    {
        public Parcial2Db() : base("ConStr")
        {
               
        }

        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Retenciones> Retenciones { get; set; }
        public virtual DbSet<TiposEmail> TiposEmail { get; set; }
    }
}
