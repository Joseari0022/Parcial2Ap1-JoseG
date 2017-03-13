using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace Parcial2Ap1_JoseG.UI.Registros
{
    public partial class RegistrosEmpleados : Form
    {
        public RegistrosEmpleados()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();

        private void Idbutton_Click(object sender, EventArgs e)
        {
            Pasar(EmpleadosBll.Buscar(u.String(IdtextBox.Text)));
        }

        private void Pasar(Empleados e)
        {
            IdtextBox.Text = e.EmpleadoId.ToString();
            NombretextBox.Text = e.Nombres;
            FechaNacimientodateTimePicker.Value = e.FechaNacimiento;
            SueldotextBox.Text = e.Sueldo.ToString();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            SueldotextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Empleados emple = new Empleados();
            Llenar(emple);
            EmpleadosBll.Guardar(emple);
            MessageBox.Show("Guardado con exito!!!!");
        }

        private void Llenar(Empleados em)
        {
            em.Nombres = NombretextBox.Text;
            em.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            em.Sueldo = Convert.ToInt32(SueldotextBox.Text);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            EmpleadosBll.Eliminar(u.String(IdtextBox.Text));
            MessageBox.Show("Eliminado con exito!!!!");
        }
    }
}
