using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csvTransf
{
    public partial class FormPrikaz : Form
    {
        public FormPrikaz()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            FromFiltriranje frmfiltriraj = new FromFiltriranje();
            frmfiltriraj.Show();
        }
    }
}
