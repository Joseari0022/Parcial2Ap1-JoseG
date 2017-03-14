using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class Parcial2Db : DbContext
    {
        public Parcial2Db() : base("ConStr")
        {

        }

        public virtual DbSet<Retenciones> Retenciones { get; set; }
        public virtual DbSet<TiposEmails> TipoEmail { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }


    }
}
