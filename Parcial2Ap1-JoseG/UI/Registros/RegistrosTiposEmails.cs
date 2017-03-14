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
    public partial class RegistrosTiposEmails : Form
    {
        public RegistrosTiposEmails()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();

        private void Idbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdtextBox.Text))
            {
                MessageBox.Show("No Encontrado Faltan Campos");
            }
            else
            {
                int id = u.String(IdtextBox.Text);
                TiposEmails te = new TiposEmails();

                te = TiposEmailBll.Buscar(p => p.TipoId == id);
                if (te != null)
                {
                    pasar(te);

                }
                else
                {
                    MessageBox.Show("No exite!!!");
                }
            }
        }

        private void pasar(TiposEmails te)
        {
            IdtextBox.Text = te.TipoId.ToString();
            DescripciontextBox.Text = te.Descripcion;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IdtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            TiposEmails te = new TiposEmails();
            if (!Validar())
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                Llenar(te);
                if (te != null)
                {
                    if (TiposEmailBll.Guardar(te))
                        MessageBox.Show("Guardado con exito!!!");
                    else
                        MessageBox.Show("No guardado!!!");
                }
                Limpiar();
            }
        }

        private bool Validar()
        {
            bool cambio = true;

            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                DescripcionerrorProvider.SetError(DescripciontextBox, "Por favor llenar el campo");
                cambio = false;
            }
            return cambio;
        }

        private void Llenar(TiposEmails te)
        {
            te.Descripcion = DescripciontextBox.Text;
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
                if (TiposEmailBll.Eliminar(TiposEmailBll.Buscar(p => p.TipoId == id)))
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
    }
}
