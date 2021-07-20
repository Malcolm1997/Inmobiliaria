using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class Form1 : Form
    {

        public MODELO.Propiedad oPropiedad;
        public MODELO.Inmobilaria oInmobiliaria;

        public Form1()
        {
            InitializeComponent();
            gbxCARGA.Enabled = false;
            
        }


        public void cambiarAcciones()
        {
            gbxACCIONES.Enabled = true;
            gbxCARGA.Enabled = false;
        }

        public void cambiarCarga()
        {
            gbxCARGA.Enabled = true;
            gbxACCIONES.Enabled = false;
        }

        public void GRILLA()
        {
            dgwALQUILERES.DataSource = null;
            dgwALQUILERES.DataSource = oPropiedad;
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            cambiarCarga();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            cambiarCarga();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            cambiarCarga();

        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            cambiarCarga();

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGUARDAR_Click(object sender, EventArgs e)
        {
            cambiarAcciones();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            cambiarAcciones();
        }

        
    }
}
