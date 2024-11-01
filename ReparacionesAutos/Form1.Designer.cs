namespace ReparacionesAutos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbMarca = new MetroFramework.Controls.MetroTextBox();
            this.tbModelo = new MetroFramework.Controls.MetroTextBox();
            this.tbAnio = new MetroFramework.Controls.MetroTextBox();
            this.tbMatricula = new MetroFramework.Controls.MetroTextBox();
            this.cmbReparacion = new MetroFramework.Controls.MetroComboBox();
            this.cbSeguro = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.dgvAutos = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Marca de Auto:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Modelo:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 131);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Año:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 170);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Matricula:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 218);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(127, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Tipo de Reparacion:";
            // 
            // tbMarca
            // 
            // 
            // 
            // 
            this.tbMarca.CustomButton.Image = null;
            this.tbMarca.CustomButton.Location = new System.Drawing.Point(218, 2);
            this.tbMarca.CustomButton.Name = "";
            this.tbMarca.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMarca.CustomButton.TabIndex = 1;
            this.tbMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMarca.CustomButton.UseSelectable = true;
            this.tbMarca.CustomButton.Visible = false;
            this.tbMarca.Lines = new string[0];
            this.tbMarca.Location = new System.Drawing.Point(229, 41);
            this.tbMarca.MaxLength = 32767;
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.PasswordChar = '\0';
            this.tbMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMarca.SelectedText = "";
            this.tbMarca.SelectionLength = 0;
            this.tbMarca.SelectionStart = 0;
            this.tbMarca.ShortcutsEnabled = true;
            this.tbMarca.Size = new System.Drawing.Size(238, 22);
            this.tbMarca.TabIndex = 6;
            this.tbMarca.UseSelectable = true;
            this.tbMarca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMarca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbModelo
            // 
            // 
            // 
            // 
            this.tbModelo.CustomButton.Image = null;
            this.tbModelo.CustomButton.Location = new System.Drawing.Point(215, 2);
            this.tbModelo.CustomButton.Name = "";
            this.tbModelo.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbModelo.CustomButton.TabIndex = 1;
            this.tbModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbModelo.CustomButton.UseSelectable = true;
            this.tbModelo.CustomButton.Visible = false;
            this.tbModelo.Lines = new string[0];
            this.tbModelo.Location = new System.Drawing.Point(232, 83);
            this.tbModelo.MaxLength = 32767;
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.PasswordChar = '\0';
            this.tbModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbModelo.SelectedText = "";
            this.tbModelo.SelectionLength = 0;
            this.tbModelo.SelectionStart = 0;
            this.tbModelo.ShortcutsEnabled = true;
            this.tbModelo.Size = new System.Drawing.Size(235, 22);
            this.tbModelo.TabIndex = 7;
            this.tbModelo.UseSelectable = true;
            this.tbModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbAnio
            // 
            // 
            // 
            // 
            this.tbAnio.CustomButton.Image = null;
            this.tbAnio.CustomButton.Location = new System.Drawing.Point(105, 2);
            this.tbAnio.CustomButton.Name = "";
            this.tbAnio.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbAnio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAnio.CustomButton.TabIndex = 1;
            this.tbAnio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAnio.CustomButton.UseSelectable = true;
            this.tbAnio.CustomButton.Visible = false;
            this.tbAnio.Lines = new string[0];
            this.tbAnio.Location = new System.Drawing.Point(232, 128);
            this.tbAnio.MaxLength = 32767;
            this.tbAnio.Name = "tbAnio";
            this.tbAnio.PasswordChar = '\0';
            this.tbAnio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAnio.SelectedText = "";
            this.tbAnio.SelectionLength = 0;
            this.tbAnio.SelectionStart = 0;
            this.tbAnio.ShortcutsEnabled = true;
            this.tbAnio.Size = new System.Drawing.Size(125, 22);
            this.tbAnio.TabIndex = 8;
            this.tbAnio.UseSelectable = true;
            this.tbAnio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAnio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbMatricula
            // 
            // 
            // 
            // 
            this.tbMatricula.CustomButton.Image = null;
            this.tbMatricula.CustomButton.Location = new System.Drawing.Point(105, 2);
            this.tbMatricula.CustomButton.Name = "";
            this.tbMatricula.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbMatricula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMatricula.CustomButton.TabIndex = 1;
            this.tbMatricula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMatricula.CustomButton.UseSelectable = true;
            this.tbMatricula.CustomButton.Visible = false;
            this.tbMatricula.Lines = new string[0];
            this.tbMatricula.Location = new System.Drawing.Point(229, 164);
            this.tbMatricula.MaxLength = 32767;
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.PasswordChar = '\0';
            this.tbMatricula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMatricula.SelectedText = "";
            this.tbMatricula.SelectionLength = 0;
            this.tbMatricula.SelectionStart = 0;
            this.tbMatricula.ShortcutsEnabled = true;
            this.tbMatricula.Size = new System.Drawing.Size(125, 22);
            this.tbMatricula.TabIndex = 9;
            this.tbMatricula.UseSelectable = true;
            this.tbMatricula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMatricula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbReparacion
            // 
            this.cmbReparacion.FormattingEnabled = true;
            this.cmbReparacion.ItemHeight = 23;
            this.cmbReparacion.Location = new System.Drawing.Point(232, 215);
            this.cmbReparacion.Name = "cmbReparacion";
            this.cmbReparacion.Size = new System.Drawing.Size(156, 29);
            this.cmbReparacion.TabIndex = 10;
            this.cmbReparacion.UseSelectable = true;
            // 
            // cbSeguro
            // 
            this.cbSeguro.AutoSize = true;
            this.cbSeguro.Location = new System.Drawing.Point(37, 267);
            this.cbSeguro.Name = "cbSeguro";
            this.cbSeguro.Size = new System.Drawing.Size(60, 15);
            this.cbSeguro.TabIndex = 11;
            this.cbSeguro.Text = "Seguro";
            this.cbSeguro.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.cmbReparacion);
            this.groupBox1.Controls.Add(this.cbSeguro);
            this.groupBox1.Controls.Add(this.tbMatricula);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.tbAnio);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.tbModelo);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.tbMarca);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(52, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 413);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(48, 315);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 59);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvAutos
            // 
            this.dgvAutos.AllowUserToAddRows = false;
            this.dgvAutos.AllowUserToDeleteRows = false;
            this.dgvAutos.AllowUserToOrderColumns = true;
            this.dgvAutos.AllowUserToResizeRows = false;
            this.dgvAutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAutos.EnableHeadersVisualStyles = false;
            this.dgvAutos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAutos.Location = new System.Drawing.Point(667, 98);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.ReadOnly = true;
            this.dgvAutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAutos.RowHeadersWidth = 62;
            this.dgvAutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAutos.RowTemplate.Height = 28;
            this.dgvAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutos.Size = new System.Drawing.Size(597, 401);
            this.dgvAutos.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 544);
            this.Controls.Add(this.dgvAutos);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Reparacion de Auto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbMarca;
        private MetroFramework.Controls.MetroTextBox tbModelo;
        private MetroFramework.Controls.MetroTextBox tbAnio;
        private MetroFramework.Controls.MetroTextBox tbMatricula;
        private MetroFramework.Controls.MetroComboBox cmbReparacion;
        private MetroFramework.Controls.MetroCheckBox cbSeguro;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroGrid dgvAutos;
    }
}

