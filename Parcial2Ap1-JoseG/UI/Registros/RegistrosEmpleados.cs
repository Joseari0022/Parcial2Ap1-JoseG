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
        Empleados em = new Empleados();
        EmpleadosEmails de = new EmpleadosEmails();

        private void Idbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdtextBox.Text))
            {
                MessageBox.Show("No Encontrado Faltan Campos");
            }
            else
            {
                int id = u.String(IdtextBox.Text);
                Empleados emp = new Empleados();

                emp = EmpleadosBll.Buscar(p => p.EmpleadoId == id);
                if (emp != null)
                {
                    Pasar(emp);
                    PasarRetencionData(emp);
                    PasarEmailsData(emp);
                }
                else
                {
                    MessageBox.Show("No exite!!!");
                }
            }
        }

        private void Pasar(Empleados e)
        {
            IdtextBox.Text = e.EmpleadoId.ToString();
            NombretextBox.Text = e.Nombres;
            FechaNacimientodateTimePicker.Value = e.FechaNacimiento;
            SueldotextBox.Text = e.Sueldo.ToString();
        }

        private void PasarRetencionData(Empleados empl)
        {
            RetencionesdataGridView.DataSource = null;
            RetencionesdataGridView.DataSource = empl.Retenciones;
        }

        private void PasarEmailsData(Empleados empl)
        {
            EmailsdataGridView.DataSource = null;
            EmailsdataGridView.DataSource = empl.Relacion.ToList();

            this.EmailsdataGridView.Columns["EmpleadoId"].Visible = false;
            this.EmailsdataGridView.Columns["Id"].Visible = false;
            this.EmailsdataGridView.Columns["TipoEmail"].Visible = false;
            this.EmailsdataGridView.Columns["Empleado"].Visible = false;
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
            FechaNacimientodateTimePicker.Value = DateTime.Today;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Empleados emple = new Empleados();
            if (!Validar())
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                Llenar(emple);
                if (emple != null)
                {
                    if (EmpleadosBll.Guardar(emple))
                        MessageBox.Show("Guardado con exito!!!");
                    else
                        MessageBox.Show("No guardado!!!");
                }
                Limpiar();
            }
        }

        private void Llenar(Empleados em)
        {
            em.Nombres = NombretextBox.Text;
            em.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            em.Sueldo = Convert.ToInt32(SueldotextBox.Text);
            em.RetencionId = (int)RetencioncomboBox.SelectedValue;
        }

        private bool Validar()
        {
            bool cambio = true;

            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                VacioserrorProvider.SetError(NombretextBox, "Campo vacio!!!!");
                cambio = false;
            }
            if (string.IsNullOrEmpty(SueldotextBox.Text))
            {
                VacioserrorProvider.SetError(SueldotextBox, "Campo vacio!!!!");
                cambio = false;
            }
            if (RetencionesdataGridView.DataSource == null)
            {
                VacioserrorProvider.SetError(RetencionesdataGridView, "Campo vacio!!!!");
                cambio = false;
            }
            if (EmailsdataGridView.DataSource == null)
            {
                VacioserrorProvider.SetError(EmailsdataGridView, "Campo vacio!!!!");
                cambio = false;
            }

            return cambio;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdtextBox.Text))
            {
                MessageBox.Show("No Eliminado Faltan Campos");
            }
            else
            {

                int id = u.String(IdtextBox.Text);
                if (EmpleadosBll.Eliminar(EmpleadosBll.Buscar(p => p.EmpleadoId == id)))
                {
                    Limpiar();
                    MessageBox.Show("Eliminado con exito!!!");
                }
                else
                {
                    MessageBox.Show("No eliminado!!!");
                }
            }
        }

        private void Idbutton_Click_1(object sender, EventArgs e)
        {

        }

        private void AgregarRetencionbutton_Click(object sender, EventArgs e)
        {
            Retenciones rete = new Retenciones();

            rete = (Retenciones)RetencioncomboBox.SelectedItem;
            em.Retenciones.Add(rete);

            PasarRetencionData(em);
        }

        private void AgregarEmilsbutton_Click(object sender, EventArgs e)
        {
            em.Agregar(de.TipoEmail, EmailtextBox.Text);

            PasarEmailsData(em);
        }
    }
}
