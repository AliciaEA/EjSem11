using ReparacionesAutos.Modelos;
using ReparacionesAutos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReparacionesAutos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        RegistroAuto autos = new RegistroAuto();
        int contadorAutos = 0;
        public Form1()
        {
            InitializeComponent();
            cmbReparacion.DataSource = Enum.GetValues(typeof(Modelos.TipoReparacion));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Auto auto = new Auto();
                auto.Id = contadorAutos;
                contadorAutos++;
                auto.Marca = tbMarca.Text;
                auto.Modelo = tbModelo.Text;
                auto.Año = int.Parse(tbAnio.Text);
                auto.Matricula = tbMatricula.Text;
                auto.TipoReparacion = (TipoReparacion)cmbReparacion.SelectedItem;
                auto.Seguro = cbSeguro.Checked;

                autos.AgregarAuto(auto);

                MessageBox.Show("Auto agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();

                ActualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ActualizarLista()
        {
            dgvAutos.DataSource = null;
            dgvAutos.DataSource = autos.ObtenerAutos();
        }

        public void LimpiarCampos()
        {
            tbMarca.Clear();
            tbModelo.Clear();
            tbAnio.Clear();
            tbMatricula.Clear();
            cmbReparacion.SelectedIndex = 0;
            cbSeguro.Checked = false;
            tbMarca.Focus();
        }
    }
}
