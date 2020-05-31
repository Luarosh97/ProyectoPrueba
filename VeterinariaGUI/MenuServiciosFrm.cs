using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaGUI
{
    public partial class MenuServiciosFrm : Form
    {
        public MenuServiciosFrm()
        {
            InitializeComponent();
        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AgregarServicioBtn_Click(object sender, EventArgs e)
        {
            RegistrarServicioFrm registrarServicioFrm = new RegistrarServicioFrm();
            registrarServicioFrm.Show();
        }
    }
}
