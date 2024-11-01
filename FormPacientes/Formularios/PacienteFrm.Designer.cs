namespace FormPacientes.Formularios
{
    partial class PacienteFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.tbNombre = new MetroFramework.Controls.MetroTextBox();
            this.tbMotConsul = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbAlergia = new System.Windows.Forms.CheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbDepMed = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbGenero = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtpNacimiento = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbApellido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dgvPacientes = new MetroFramework.Controls.MetroGrid();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.tbMotConsul);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cbAlergia);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cmbDepMed);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.cmbGenero);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.dtpNacimiento);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.tbApellido);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Location = new System.Drawing.Point(51, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 529);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 432);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 64);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbNombre
            // 
            // 
            // 
            // 
            this.tbNombre.CustomButton.Image = null;
            this.tbNombre.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.tbNombre.CustomButton.Name = "";
            this.tbNombre.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.tbNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNombre.CustomButton.TabIndex = 1;
            this.tbNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNombre.CustomButton.UseSelectable = true;
            this.tbNombre.CustomButton.Visible = false;
            this.tbNombre.Lines = new string[0];
            this.tbNombre.Location = new System.Drawing.Point(126, 41);
            this.tbNombre.MaxLength = 32767;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PasswordChar = '\0';
            this.tbNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNombre.SelectedText = "";
            this.tbNombre.SelectionLength = 0;
            this.tbNombre.SelectionStart = 0;
            this.tbNombre.ShortcutsEnabled = true;
            this.tbNombre.Size = new System.Drawing.Size(225, 31);
            this.tbNombre.TabIndex = 22;
            this.tbNombre.UseSelectable = true;
            this.tbNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbMotConsul
            // 
            // 
            // 
            // 
            this.tbMotConsul.CustomButton.Image = null;
            this.tbMotConsul.CustomButton.Location = new System.Drawing.Point(233, 2);
            this.tbMotConsul.CustomButton.Name = "";
            this.tbMotConsul.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.tbMotConsul.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMotConsul.CustomButton.TabIndex = 1;
            this.tbMotConsul.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMotConsul.CustomButton.UseSelectable = true;
            this.tbMotConsul.CustomButton.Visible = false;
            this.tbMotConsul.Lines = new string[0];
            this.tbMotConsul.Location = new System.Drawing.Point(166, 282);
            this.tbMotConsul.MaxLength = 32767;
            this.tbMotConsul.Multiline = true;
            this.tbMotConsul.Name = "tbMotConsul";
            this.tbMotConsul.PasswordChar = '\0';
            this.tbMotConsul.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMotConsul.SelectedText = "";
            this.tbMotConsul.SelectionLength = 0;
            this.tbMotConsul.SelectionStart = 0;
            this.tbMotConsul.ShortcutsEnabled = true;
            this.tbMotConsul.Size = new System.Drawing.Size(311, 80);
            this.tbMotConsul.TabIndex = 28;
            this.tbMotConsul.UseSelectable = true;
            this.tbMotConsul.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMotConsul.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Nombre:";
            // 
            // cbAlergia
            // 
            this.cbAlergia.AutoSize = true;
            this.cbAlergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlergia.Location = new System.Drawing.Point(20, 378);
            this.cbAlergia.Name = "cbAlergia";
            this.cbAlergia.Size = new System.Drawing.Size(22, 21);
            this.cbAlergia.TabIndex = 27;
            this.cbAlergia.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Apellido:";
            // 
            // cmbDepMed
            // 
            this.cmbDepMed.FormattingEnabled = true;
            this.cmbDepMed.ItemHeight = 23;
            this.cmbDepMed.Items.AddRange(new object[] {
            "Cardiologia",
            "Pediatria",
            "Emergencias",
            "Neurología"});
            this.cmbDepMed.Location = new System.Drawing.Point(166, 229);
            this.cmbDepMed.Name = "cmbDepMed";
            this.cmbDepMed.Size = new System.Drawing.Size(139, 29);
            this.cmbDepMed.TabIndex = 26;
            this.cmbDepMed.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 130);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(136, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Fecha de Nacimiento:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.ItemHeight = 23;
            this.cmbGenero.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbGenero.Location = new System.Drawing.Point(126, 176);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(139, 29);
            this.cmbGenero.TabIndex = 25;
            this.cmbGenero.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 176);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Genero:";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(166, 124);
            this.dtpNacimiento.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(224, 29);
            this.dtpNacimiento.TabIndex = 24;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 229);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(146, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Departamento Medico:";
            // 
            // tbApellido
            // 
            // 
            // 
            // 
            this.tbApellido.CustomButton.Image = null;
            this.tbApellido.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.tbApellido.CustomButton.Name = "";
            this.tbApellido.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.tbApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbApellido.CustomButton.TabIndex = 1;
            this.tbApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbApellido.CustomButton.UseSelectable = true;
            this.tbApellido.CustomButton.Visible = false;
            this.tbApellido.Lines = new string[0];
            this.tbApellido.Location = new System.Drawing.Point(126, 87);
            this.tbApellido.MaxLength = 32767;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.PasswordChar = '\0';
            this.tbApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbApellido.SelectedText = "";
            this.tbApellido.SelectionLength = 0;
            this.tbApellido.SelectionStart = 0;
            this.tbApellido.ShortcutsEnabled = true;
            this.tbApellido.Size = new System.Drawing.Size(225, 31);
            this.tbApellido.TabIndex = 23;
            this.tbApellido.UseSelectable = true;
            this.tbApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(20, 282);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(126, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "Motivo de Consulta:";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToOrderColumns = true;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvPacientes.EnableHeadersVisualStyles = false;
            this.dgvPacientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPacientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPacientes.Location = new System.Drawing.Point(714, 104);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvPacientes.RowHeadersWidth = 62;
            this.dgvPacientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPacientes.RowTemplate.Height = 28;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(510, 332);
            this.dgvPacientes.TabIndex = 14;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(44, 378);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 19);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "¿Alergias?";
            // 
            // PacienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 685);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.groupBox1);
            this.Name = "PacienteFrm";
            this.Text = "Pacientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroTextBox tbNombre;
        private MetroFramework.Controls.MetroTextBox tbMotConsul;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.CheckBox cbAlergia;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbDepMed;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbGenero;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime dtpNacimiento;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbApellido;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroGrid dgvPacientes;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}