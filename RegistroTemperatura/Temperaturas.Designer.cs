namespace RegistroTemperatura
{
    partial class Temperaturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDatoNuevo = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAgregarGrados = new System.Windows.Forms.Button();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.lblDiaIngresado = new System.Windows.Forms.Label();
            this.btnAgregarTemperatura = new System.Windows.Forms.Button();
            this.dgTemperatura = new System.Windows.Forms.DataGridView();
            this.Nª = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRepite = new System.Windows.Forms.Label();
            this.lblMayorTemp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Meteorologico Nacional";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(179, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registro Semanal";
            // 
            // dtfecha
            // 
            this.dtfecha.Location = new System.Drawing.Point(6, 36);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(200, 20);
            this.dtfecha.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblIngresar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDatoNuevo);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.btnAgregarGrados);
            this.groupBox1.Controls.Add(this.txtGrados);
            this.groupBox1.Controls.Add(this.lblDiaIngresado);
            this.groupBox1.Controls.Add(this.btnAgregarTemperatura);
            this.groupBox1.Controls.Add(this.dtfecha);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Temperaturas";
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(9, 88);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(115, 13);
            this.lblIngresar.TabIndex = 10;
            this.lblIngresar.Text = "Ingrese la temperatura ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha Inicial";
            // 
            // btnDatoNuevo
            // 
            this.btnDatoNuevo.Location = new System.Drawing.Point(91, 155);
            this.btnDatoNuevo.Name = "btnDatoNuevo";
            this.btnDatoNuevo.Size = new System.Drawing.Size(100, 23);
            this.btnDatoNuevo.TabIndex = 8;
            this.btnDatoNuevo.Text = "Nuevos Datos";
            this.btnDatoNuevo.UseVisualStyleBackColor = true;
            this.btnDatoNuevo.Click += new System.EventHandler(this.btnDatoNuevo_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(6, 155);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAgregarGrados
            // 
            this.btnAgregarGrados.Enabled = false;
            this.btnAgregarGrados.Location = new System.Drawing.Point(112, 104);
            this.btnAgregarGrados.Name = "btnAgregarGrados";
            this.btnAgregarGrados.Size = new System.Drawing.Size(79, 23);
            this.btnAgregarGrados.TabIndex = 6;
            this.btnAgregarGrados.Text = "Agregar";
            this.btnAgregarGrados.UseVisualStyleBackColor = true;
            this.btnAgregarGrados.Click += new System.EventHandler(this.btnAgregarGrados_Click);
            // 
            // txtGrados
            // 
            this.txtGrados.Enabled = false;
            this.txtGrados.Location = new System.Drawing.Point(6, 106);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(100, 20);
            this.txtGrados.TabIndex = 5;
            // 
            // lblDiaIngresado
            // 
            this.lblDiaIngresado.AutoSize = true;
            this.lblDiaIngresado.Location = new System.Drawing.Point(9, 129);
            this.lblDiaIngresado.Name = "lblDiaIngresado";
            this.lblDiaIngresado.Size = new System.Drawing.Size(162, 13);
            this.lblDiaIngresado.TabIndex = 4;
            this.lblDiaIngresado.Text = "Se digito la temperatura del dia X";
            this.lblDiaIngresado.Visible = false;
            // 
            // btnAgregarTemperatura
            // 
            this.btnAgregarTemperatura.Location = new System.Drawing.Point(38, 62);
            this.btnAgregarTemperatura.Name = "btnAgregarTemperatura";
            this.btnAgregarTemperatura.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarTemperatura.TabIndex = 3;
            this.btnAgregarTemperatura.Text = "Agregar Temperatura";
            this.btnAgregarTemperatura.UseVisualStyleBackColor = true;
            this.btnAgregarTemperatura.Click += new System.EventHandler(this.btnAgregarTemperatura_Click);
            // 
            // dgTemperatura
            // 
            this.dgTemperatura.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTemperatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTemperatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nª,
            this.Dia,
            this.Temperatura});
            this.dgTemperatura.Location = new System.Drawing.Point(235, 65);
            this.dgTemperatura.Name = "dgTemperatura";
            this.dgTemperatura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgTemperatura.RowHeadersVisible = false;
            this.dgTemperatura.Size = new System.Drawing.Size(271, 184);
            this.dgTemperatura.TabIndex = 4;
            // 
            // Nª
            // 
            this.Nª.HeaderText = "Nª";
            this.Nª.Name = "Nª";
            this.Nª.ReadOnly = true;
            this.Nª.Width = 30;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // Temperatura
            // 
            this.Temperatura.HeaderText = "Temperatura";
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(219, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRepite
            // 
            this.lblRepite.AutoSize = true;
            this.lblRepite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepite.ForeColor = System.Drawing.Color.Yellow;
            this.lblRepite.Location = new System.Drawing.Point(120, 298);
            this.lblRepite.Name = "lblRepite";
            this.lblRepite.Size = new System.Drawing.Size(254, 20);
            this.lblRepite.TabIndex = 7;
            this.lblRepite.Text = "Se repitio en los ultimos 5 dias";
            this.lblRepite.Visible = false;
            // 
            // lblMayorTemp
            // 
            this.lblMayorTemp.AutoSize = true;
            this.lblMayorTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayorTemp.ForeColor = System.Drawing.Color.Red;
            this.lblMayorTemp.Location = new System.Drawing.Point(137, 278);
            this.lblMayorTemp.Name = "lblMayorTemp";
            this.lblMayorTemp.Size = new System.Drawing.Size(233, 20);
            this.lblMayorTemp.TabIndex = 6;
            this.lblMayorTemp.Text = "La mayor temperatura fue X";
            this.lblMayorTemp.Visible = false;
            // 
            // Temperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(518, 366);
            this.Controls.Add(this.lblRepite);
            this.Controls.Add(this.lblMayorTemp);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgTemperatura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Temperaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperaturas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTemperatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDatoNuevo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnAgregarGrados;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.Label lblDiaIngresado;
        private System.Windows.Forms.Button btnAgregarTemperatura;
        private System.Windows.Forms.DataGridView dgTemperatura;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRepite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nª;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperatura;
        private System.Windows.Forms.Label lblMayorTemp;
    }
}