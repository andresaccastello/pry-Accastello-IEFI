namespace pry_Accastello_IEFI
{
    partial class frmTareas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdTiempoLargo = new System.Windows.Forms.RadioButton();
            this.rdTiempoCorto = new System.Windows.Forms.RadioButton();
            this.rdPendiente = new System.Windows.Forms.RadioButton();
            this.rdEfectuado = new System.Windows.Forms.RadioButton();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grbPago = new System.Windows.Forms.GroupBox();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.btnAgregarG = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.btnAgregarLugar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNombreLugar = new System.Windows.Forms.TextBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.dgvGrilla2 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbPago.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 8;
            // 
            // rdTiempoLargo
            // 
            this.rdTiempoLargo.AutoSize = true;
            this.rdTiempoLargo.Location = new System.Drawing.Point(14, 19);
            this.rdTiempoLargo.Name = "rdTiempoLargo";
            this.rdTiempoLargo.Size = new System.Drawing.Size(79, 17);
            this.rdTiempoLargo.TabIndex = 9;
            this.rdTiempoLargo.TabStop = true;
            this.rdTiempoLargo.Text = "Prolongada";
            this.rdTiempoLargo.UseVisualStyleBackColor = true;
            // 
            // rdTiempoCorto
            // 
            this.rdTiempoCorto.AutoSize = true;
            this.rdTiempoCorto.Location = new System.Drawing.Point(14, 44);
            this.rdTiempoCorto.Name = "rdTiempoCorto";
            this.rdTiempoCorto.Size = new System.Drawing.Size(94, 17);
            this.rdTiempoCorto.TabIndex = 10;
            this.rdTiempoCorto.TabStop = true;
            this.rdTiempoCorto.Text = "Poca duracion";
            this.rdTiempoCorto.UseVisualStyleBackColor = true;
            // 
            // rdPendiente
            // 
            this.rdPendiente.AutoSize = true;
            this.rdPendiente.Location = new System.Drawing.Point(6, 51);
            this.rdPendiente.Name = "rdPendiente";
            this.rdPendiente.Size = new System.Drawing.Size(73, 17);
            this.rdPendiente.TabIndex = 11;
            this.rdPendiente.TabStop = true;
            this.rdPendiente.Text = "Pendiente";
            this.rdPendiente.UseVisualStyleBackColor = true;
            // 
            // rdEfectuado
            // 
            this.rdEfectuado.AutoSize = true;
            this.rdEfectuado.Location = new System.Drawing.Point(6, 28);
            this.rdEfectuado.Name = "rdEfectuado";
            this.rdEfectuado.Size = new System.Drawing.Size(74, 17);
            this.rdEfectuado.TabIndex = 12;
            this.rdEfectuado.TabStop = true;
            this.rdEfectuado.Text = "Efectuado";
            this.rdEfectuado.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(223, 120);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 14;
            this.btnCargar.Text = "AGREGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.grbPago);
            this.groupBox2.Controls.Add(this.btnCancelar2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 196);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Especificaciones";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(160, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comentarios";
            // 
            // grbPago
            // 
            this.grbPago.Controls.Add(this.rdEfectuado);
            this.grbPago.Controls.Add(this.rdPendiente);
            this.grbPago.Location = new System.Drawing.Point(6, 108);
            this.grbPago.Name = "grbPago";
            this.grbPago.Size = new System.Drawing.Size(116, 78);
            this.grbPago.TabIndex = 20;
            this.grbPago.TabStop = false;
            this.grbPago.Text = "Pago";
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.Location = new System.Drawing.Point(223, 161);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar2.TabIndex = 15;
            this.btnCancelar2.Text = "CANCELAR";
            this.btnCancelar2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdTiempoCorto);
            this.groupBox3.Controls.Add(this.rdTiempoLargo);
            this.groupBox3.Location = new System.Drawing.Point(6, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 77);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duracion";
            // 
            // cmbTarea
            // 
            this.cmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(6, 19);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(197, 21);
            this.cmbTarea.TabIndex = 1;
            // 
            // cmbLugar
            // 
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(6, 19);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(197, 21);
            this.cmbLugar.TabIndex = 0;
            // 
            // btnAgregarG
            // 
            this.btnAgregarG.Location = new System.Drawing.Point(363, 214);
            this.btnAgregarG.Name = "btnAgregarG";
            this.btnAgregarG.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarG.TabIndex = 15;
            this.btnAgregarG.Text = "AGREAGR";
            this.btnAgregarG.UseVisualStyleBackColor = true;
            this.btnAgregarG.Click += new System.EventHandler(this.btnAgregarG_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(6, 16);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(176, 20);
            this.dtFecha.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGrilla);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAgregarG);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 243);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar tarea";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtFecha);
            this.groupBox7.Location = new System.Drawing.Point(223, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 48);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Fecha";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbTarea);
            this.groupBox6.Controls.Add(this.txtNombreTarea);
            this.groupBox6.Controls.Add(this.btnAgregarLugar);
            this.groupBox6.Location = new System.Drawing.Point(1, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(208, 87);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tarea";
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Location = new System.Drawing.Point(11, 61);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(79, 20);
            this.txtNombreTarea.TabIndex = 19;
            // 
            // btnAgregarLugar
            // 
            this.btnAgregarLugar.Location = new System.Drawing.Point(131, 60);
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.Size = new System.Drawing.Size(72, 20);
            this.btnAgregarLugar.TabIndex = 16;
            this.btnAgregarLugar.Text = "AGREAGR";
            this.btnAgregarLugar.UseVisualStyleBackColor = true;
            this.btnAgregarLugar.Click += new System.EventHandler(this.btnAgregarLugar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbLugar);
            this.groupBox5.Controls.Add(this.txtNombreLugar);
            this.groupBox5.Controls.Add(this.btnAgregarTarea);
            this.groupBox5.Location = new System.Drawing.Point(1, 137);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(208, 87);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lugar";
            // 
            // txtNombreLugar
            // 
            this.txtNombreLugar.Location = new System.Drawing.Point(11, 60);
            this.txtNombreLugar.Name = "txtNombreLugar";
            this.txtNombreLugar.Size = new System.Drawing.Size(79, 20);
            this.txtNombreLugar.TabIndex = 18;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Location = new System.Drawing.Point(131, 58);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(72, 23);
            this.btnAgregarTarea.TabIndex = 17;
            this.btnAgregarTarea.Text = "AGREAGR";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowDrop = true;
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.AllowUserToResizeColumns = false;
            this.dgvGrilla.AllowUserToResizeRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(215, 80);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(222, 115);
            this.dgvGrilla.TabIndex = 22;
            // 
            // dgvGrilla2
            // 
            this.dgvGrilla2.AllowDrop = true;
            this.dgvGrilla2.AllowUserToAddRows = false;
            this.dgvGrilla2.AllowUserToDeleteRows = false;
            this.dgvGrilla2.AllowUserToResizeColumns = false;
            this.dgvGrilla2.AllowUserToResizeRows = false;
            this.dgvGrilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla2.Location = new System.Drawing.Point(472, 12);
            this.dgvGrilla2.MultiSelect = false;
            this.dgvGrilla2.Name = "dgvGrilla2";
            this.dgvGrilla2.ReadOnly = true;
            this.dgvGrilla2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla2.Size = new System.Drawing.Size(627, 261);
            this.dgvGrilla2.TabIndex = 23;
            // 
            // frmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.dgvGrilla2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTareas";
            this.Text = "frmTareas";
            this.Load += new System.EventHandler(this.frmTareas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbPago.ResumeLayout(false);
            this.grbPago.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdTiempoLargo;
        private System.Windows.Forms.RadioButton rdTiempoCorto;
        private System.Windows.Forms.RadioButton rdPendiente;
        private System.Windows.Forms.RadioButton rdEfectuado;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.Button btnAgregarG;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.TextBox txtNombreLugar;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnAgregarLugar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox grbPago;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridView dgvGrilla2;
    }
}