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
    public partial class RegistrosRetenciones : Form
    {
        public RegistrosRetenciones()
        {
            InitializeComponent();
        }

        private void Idbutton_Click(object sender, EventArgs e)
        {

        }

        private void pasar(Retenciones rt)
        {
            IdtextBox.Text = rt.RetencionId.ToString();
            DescripciontextBox.Text = DescripciontextBox
        }
    }
}
