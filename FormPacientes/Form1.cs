using FormPacientes.Formularios;
using MetroFramework.Components;
using MetroFramework.Forms;
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
            StyleManager = metroStyleManager1;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm is MetroForm metroChildForm)
                {
                    metroChildForm.StyleManager = metroStyleManager1;
                }
            }

        }

        private void registroPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacienteFrm frm = new PacienteFrm();
            frm.MdiParent = this;
            frm.StyleManager = metroStyleManager1;
            frm.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {

            metroStyleManager1.Theme = metroToggle1.Checked ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light;




        }

    }
}
