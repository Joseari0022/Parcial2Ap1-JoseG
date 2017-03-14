using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadosRetenciones
    {
        [Key]
        public int Id { get; set; }
        public int EmpleadosId { get; set; }
        public int RetencionesId { get; set; }
    }
}
