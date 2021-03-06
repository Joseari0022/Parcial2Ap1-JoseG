﻿using System;
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
    public partial class RegistrosRetenciones : Form
    {
        public RegistrosRetenciones()
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
                Retenciones rete = new Retenciones();

                rete = RetencionesBll.Buscar(p => p.RetencionId == id);
                if(rete != null)
                {
                    pasar(rete);
                   
                }
                else
                {
                    MessageBox.Show("No exite!!!");
                }
            }
        }

        private void pasar(Retenciones rt)
        {
            IdtextBox.Text = rt.RetencionId.ToString();
            DescripciontextBox.Text = rt.Descripcion;
            ValortextBox.Text = rt.Valor.ToString();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IdtextBox.Clear();
            DescripciontextBox.Clear();
            ValortextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Retenciones rete = new Retenciones();
            if(!Validar())
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                Llenar(rete);
                if(rete != null)
                {
                    if (RetencionesBll.Guardar(rete))
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
            if (string.IsNullOrEmpty(ValortextBox.Text))
            {
                ValorerrorProvider.SetError(ValortextBox, "Por favor llenar el campo");
                cambio = false;
            }

            return cambio;
        }

        private void Llenar(Retenciones r)
        {
            r.Descripcion = DescripciontextBox.Text;
            r.Valor = Convert.ToInt32(ValortextBox);
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
                if (RetencionesBll.Eliminar(RetencionesBll.Buscar(p => p.RetencionId == id)))
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
