using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadosEmails
    {
        [Key]
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public int TipoId { get; set; }
        public string Email { get; set; }
        
        public virtual TiposEmails TipoEmail { get; set; }
        public virtual Empleados Empleados { get; set; }

        public EmpleadosEmails()
        {
            this.TipoEmail = new TiposEmails();
        }

        public EmpleadosEmails(int tipoid, string email)
        {
            this.TipoId = tipoid;
            this.Email = email;
        }
    }
}
