using FormPacientes.Modelos;
using FormPacientes.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPacientes.Formularios
{
    public partial class PacienteFrm : MetroFramework.Forms.MetroForm
    {
        RegistroPaciente pacientes;
        int contadorPac = 0;
        public PacienteFrm()
        {
            InitializeComponent();
            cmbDepMed.DataSource = Enum.GetValues(typeof(DepartamentoMedico));
            pacientes = new RegistroPaciente();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            try
            {
                paciente.ID = contadorPac;
                contadorPac++;
                paciente.Name = tbNombre.Text;
                paciente.Lastname = tbApellido.Text;
                paciente.FechaNac = dtpNacimiento.Value;
                paciente.Genero = Convert.ToChar(cmbGenero.Text);
                paciente.Departamento = (DepartamentoMedico)cmbDepMed.SelectedItem;
                paciente.Descripcion = tbMotConsul.Text;
                paciente.Alergias = cbAlergia.Checked;

                pacientes.AgregarPaciente(paciente);

                MessageBox.Show("Paciente agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                MostrarPacientes();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void MostrarPacientes()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = pacientes.ObtenerPacientes();
        }
        public void Limpiar()
        {
            tbNombre.Clear();
            tbApellido.Clear();
            dtpNacimiento.Value = DateTime.Now;
            cmbGenero.SelectedIndex = 0;
            cmbDepMed.SelectedIndex = 0;
            tbMotConsul.Clear();
            cbAlergia.Checked = false;
            tbNombre.Focus();
        }
    }
}
