using FormPacientes.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPacientes
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void registroPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacienteFrm frm = new PacienteFrm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
