using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public float Sueldo { get; set; }
        public int RetencionId { get; set; }

        public virtual List<Retenciones> Retenciones { get; set; }
        public virtual ICollection<EmpleadosEmails> Relacion { get; set; }

        public Empleados()
        {
            this.Retenciones = new List<Entidades.Retenciones>();
            this.Relacion = new HashSet<EmpleadosEmails>();
        }

        public void Agregar(TiposEmails tipoemil, string email)
        {
            this.Relacion.Add(new EmpleadosEmails(tipoemil.TipoId, email));
        }
    }
}
