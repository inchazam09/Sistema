
namespace Sistema.UI
{
    partial class AgregarUsuario
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.lblCantidadMaterias = new System.Windows.Forms.Label();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.rdbFuncionario = new System.Windows.Forms.RadioButton();
            this.rdbEstudiante = new System.Windows.Forms.RadioButton();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.mskCantidadMaterias = new System.Windows.Forms.MaskedTextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblDolarEstudiante = new System.Windows.Forms.Label();
            this.lblDolarFuncionario = new System.Windows.Forms.Label();
            this.gpbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(181, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(534, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 33);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(423, 365);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 33);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.Enabled = false;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "Plataforma",
            "Docente",
            "Administrativo",
            "Director"});
            this.cmbPerfil.Location = new System.Drawing.Point(495, 238);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(121, 24);
            this.cmbPerfil.TabIndex = 6;
            this.cmbPerfil.TextChanged += new System.EventHandler(this.cmbPerfil_TextChanged);
            // 
            // lblCantidadMaterias
            // 
            this.lblCantidadMaterias.AutoSize = true;
            this.lblCantidadMaterias.Enabled = false;
            this.lblCantidadMaterias.Location = new System.Drawing.Point(368, 121);
            this.lblCantidadMaterias.Name = "lblCantidadMaterias";
            this.lblCantidadMaterias.Size = new System.Drawing.Size(142, 17);
            this.lblCantidadMaterias.TabIndex = 7;
            this.lblCantidadMaterias.Text = "Cantidad de materias";
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.rdbFuncionario);
            this.gpbTipo.Controls.Add(this.rdbEstudiante);
            this.gpbTipo.Location = new System.Drawing.Point(43, 340);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(261, 73);
            this.gpbTipo.TabIndex = 4;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo";
            // 
            // rdbFuncionario
            // 
            this.rdbFuncionario.AutoSize = true;
            this.rdbFuncionario.Location = new System.Drawing.Point(144, 35);
            this.rdbFuncionario.Name = "rdbFuncionario";
            this.rdbFuncionario.Size = new System.Drawing.Size(103, 21);
            this.rdbFuncionario.TabIndex = 2;
            this.rdbFuncionario.TabStop = true;
            this.rdbFuncionario.Text = "Funcionario";
            this.rdbFuncionario.UseVisualStyleBackColor = true;
            this.rdbFuncionario.Click += new System.EventHandler(this.rdbFuncionario_Click);
            // 
            // rdbEstudiante
            // 
            this.rdbEstudiante.AutoSize = true;
            this.rdbEstudiante.Location = new System.Drawing.Point(18, 35);
            this.rdbEstudiante.Name = "rdbEstudiante";
            this.rdbEstudiante.Size = new System.Drawing.Size(96, 21);
            this.rdbEstudiante.TabIndex = 1;
            this.rdbEstudiante.TabStop = true;
            this.rdbEstudiante.Text = "Estudiante";
            this.rdbEstudiante.UseVisualStyleBackColor = true;
            this.rdbEstudiante.Click += new System.EventHandler(this.rdbEstudiante_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Enabled = false;
            this.lblPago.Location = new System.Drawing.Point(368, 176);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(41, 17);
            this.lblPago.TabIndex = 9;
            this.lblPago.Text = "Pago";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Enabled = false;
            this.lblPerfil.Location = new System.Drawing.Point(368, 241);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(40, 17);
            this.lblPerfil.TabIndex = 10;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Enabled = false;
            this.lblSalario.Location = new System.Drawing.Point(368, 301);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(52, 17);
            this.lblSalario.TabIndex = 11;
            this.lblSalario.Text = "Salario";
            // 
            // mskCedula
            // 
            this.mskCedula.Location = new System.Drawing.Point(104, 201);
            this.mskCedula.Mask = "0-0000-0000";
            this.mskCedula.Name = "mskCedula";
            this.mskCedula.Size = new System.Drawing.Size(200, 22);
            this.mskCedula.TabIndex = 2;
            // 
            // mskCantidadMaterias
            // 
            this.mskCantidadMaterias.Enabled = false;
            this.mskCantidadMaterias.Location = new System.Drawing.Point(516, 118);
            this.mskCantidadMaterias.Mask = "0";
            this.mskCantidadMaterias.Name = "mskCantidadMaterias";
            this.mskCantidadMaterias.Size = new System.Drawing.Size(100, 22);
            this.mskCantidadMaterias.TabIndex = 5;
            this.mskCantidadMaterias.TextChanged += new System.EventHandler(this.mskCantidadMaterias_TextChanged);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(187, 266);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(117, 22);
            this.dtpFechaNacimiento.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtPago
            // 
            this.txtPago.Enabled = false;
            this.txtPago.Location = new System.Drawing.Point(495, 173);
            this.txtPago.Name = "txtPago";
            this.txtPago.ReadOnly = true;
            this.txtPago.Size = new System.Drawing.Size(121, 22);
            this.txtPago.TabIndex = 16;
            // 
            // txtSalario
            // 
            this.txtSalario.Enabled = false;
            this.txtSalario.Location = new System.Drawing.Point(495, 298);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ReadOnly = true;
            this.txtSalario.Size = new System.Drawing.Size(121, 22);
            this.txtSalario.TabIndex = 17;
            // 
            // lblDolarEstudiante
            // 
            this.lblDolarEstudiante.AutoSize = true;
            this.lblDolarEstudiante.Location = new System.Drawing.Point(458, 176);
            this.lblDolarEstudiante.Name = "lblDolarEstudiante";
            this.lblDolarEstudiante.Size = new System.Drawing.Size(16, 17);
            this.lblDolarEstudiante.TabIndex = 18;
            this.lblDolarEstudiante.Text = "$";
            // 
            // lblDolarFuncionario
            // 
            this.lblDolarFuncionario.AutoSize = true;
            this.lblDolarFuncionario.Location = new System.Drawing.Point(458, 301);
            this.lblDolarFuncionario.Name = "lblDolarFuncionario";
            this.lblDolarFuncionario.Size = new System.Drawing.Size(16, 17);
            this.lblDolarFuncionario.TabIndex = 19;
            this.lblDolarFuncionario.Text = "$";
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 436);
            this.Controls.Add(this.lblDolarFuncionario);
            this.Controls.Add(this.lblDolarEstudiante);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.mskCantidadMaterias);
            this.Controls.Add(this.mskCedula);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.gpbTipo);
            this.Controls.Add(this.lblCantidadMaterias);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(675, 483);
            this.MinimumSize = new System.Drawing.Size(675, 483);
            this.Name = "AgregarUsuario";
            this.Text = "Información de Usuario";
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label lblCantidadMaterias;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton rdbFuncionario;
        private System.Windows.Forms.RadioButton rdbEstudiante;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.MaskedTextBox mskCedula;
        private System.Windows.Forms.MaskedTextBox mskCantidadMaterias;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblDolarEstudiante;
        private System.Windows.Forms.Label lblDolarFuncionario;
    }
}