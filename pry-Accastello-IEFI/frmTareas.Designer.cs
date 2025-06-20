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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTareas));
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.optTiempoLargo = new System.Windows.Forms.RadioButton();
            this.optTiempoCorto = new System.Windows.Forms.RadioButton();
            this.optPendiente = new System.Windows.Forms.RadioButton();
            this.optEfectuado = new System.Windows.Forms.RadioButton();
            this.btnCargarCompleta = new System.Windows.Forms.Button();
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.btnAgregarLugar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNombreLugar = new System.Windows.Forms.TextBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvGrilla2 = new System.Windows.Forms.DataGridView();
            this.grbID = new System.Windows.Forms.GroupBox();
            this.numBuscarId = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDesacer = new System.Windows.Forms.Button();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbPago.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla2)).BeginInit();
            this.grbID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuscarId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(29, 19);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(165, 20);
            this.txtComentario.TabIndex = 8;
            // 
            // optTiempoLargo
            // 
            this.optTiempoLargo.AutoSize = true;
            this.optTiempoLargo.Checked = true;
            this.optTiempoLargo.Location = new System.Drawing.Point(14, 19);
            this.optTiempoLargo.Name = "optTiempoLargo";
            this.optTiempoLargo.Size = new System.Drawing.Size(79, 17);
            this.optTiempoLargo.TabIndex = 9;
            this.optTiempoLargo.TabStop = true;
            this.optTiempoLargo.Text = "Prolongada";
            this.optTiempoLargo.UseVisualStyleBackColor = true;
            // 
            // optTiempoCorto
            // 
            this.optTiempoCorto.AutoSize = true;
            this.optTiempoCorto.Location = new System.Drawing.Point(14, 44);
            this.optTiempoCorto.Name = "optTiempoCorto";
            this.optTiempoCorto.Size = new System.Drawing.Size(50, 17);
            this.optTiempoCorto.TabIndex = 10;
            this.optTiempoCorto.Text = "Corta";
            this.optTiempoCorto.UseVisualStyleBackColor = true;
            // 
            // optPendiente
            // 
            this.optPendiente.AutoSize = true;
            this.optPendiente.Location = new System.Drawing.Point(6, 51);
            this.optPendiente.Name = "optPendiente";
            this.optPendiente.Size = new System.Drawing.Size(73, 17);
            this.optPendiente.TabIndex = 11;
            this.optPendiente.Text = "Pendiente";
            this.optPendiente.UseVisualStyleBackColor = true;
            // 
            // optEfectuado
            // 
            this.optEfectuado.AutoSize = true;
            this.optEfectuado.Checked = true;
            this.optEfectuado.Location = new System.Drawing.Point(6, 28);
            this.optEfectuado.Name = "optEfectuado";
            this.optEfectuado.Size = new System.Drawing.Size(74, 17);
            this.optEfectuado.TabIndex = 12;
            this.optEfectuado.TabStop = true;
            this.optEfectuado.Text = "Efectuado";
            this.optEfectuado.UseVisualStyleBackColor = true;
            // 
            // btnCargarCompleta
            // 
            this.btnCargarCompleta.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCargarCompleta.Location = new System.Drawing.Point(215, 125);
            this.btnCargarCompleta.Name = "btnCargarCompleta";
            this.btnCargarCompleta.Size = new System.Drawing.Size(200, 33);
            this.btnCargarCompleta.TabIndex = 14;
            this.btnCargarCompleta.Text = "AGREGAR";
            this.btnCargarCompleta.UseVisualStyleBackColor = false;
            this.btnCargarCompleta.Click += new System.EventHandler(this.btnCargarCompleta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.grbPago);
            this.groupBox2.Controls.Add(this.btnCancelar2);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnCargarCompleta);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 203);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Especificaciones";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox4.Controls.Add(this.txtComentario);
            this.groupBox4.Location = new System.Drawing.Point(215, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comentarios";
            // 
            // grbPago
            // 
            this.grbPago.BackColor = System.Drawing.Color.NavajoWhite;
            this.grbPago.Controls.Add(this.optEfectuado);
            this.grbPago.Controls.Add(this.optPendiente);
            this.grbPago.Location = new System.Drawing.Point(24, 116);
            this.grbPago.Name = "grbPago";
            this.grbPago.Size = new System.Drawing.Size(116, 81);
            this.grbPago.TabIndex = 20;
            this.grbPago.TabStop = false;
            this.grbPago.Text = "Pago";
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar2.Location = new System.Drawing.Point(215, 164);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(200, 33);
            this.btnCancelar2.TabIndex = 15;
            this.btnCancelar2.Text = "CANCELAR";
            this.btnCancelar2.UseVisualStyleBackColor = false;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox3.Controls.Add(this.optTiempoCorto);
            this.groupBox3.Controls.Add(this.optTiempoLargo);
            this.groupBox3.Location = new System.Drawing.Point(24, 19);
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
            this.btnAgregarG.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAgregarG.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarG.Image")));
            this.btnAgregarG.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarG.Location = new System.Drawing.Point(244, 100);
            this.btnAgregarG.Name = "btnAgregarG";
            this.btnAgregarG.Size = new System.Drawing.Size(146, 40);
            this.btnAgregarG.TabIndex = 15;
            this.btnAgregarG.Text = "AGREGAR";
            this.btnAgregarG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarG.UseVisualStyleBackColor = false;
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
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAgregarG);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 243);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar tarea";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowDrop = true;
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.AllowUserToResizeColumns = false;
            this.dgvGrilla.AllowUserToResizeRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(493, 3);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(460, 115);
            this.dgvGrilla.TabIndex = 22;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.groupBox6.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox6.Controls.Add(this.cmbTarea);
            this.groupBox6.Controls.Add(this.txtNombreTarea);
            this.groupBox6.Controls.Add(this.btnAgregarLugar);
            this.groupBox6.Location = new System.Drawing.Point(1, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(208, 87);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo";
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
            this.btnAgregarLugar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAgregarLugar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarLugar.Image")));
            this.btnAgregarLugar.Location = new System.Drawing.Point(159, 46);
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.Size = new System.Drawing.Size(36, 35);
            this.btnAgregarLugar.TabIndex = 16;
            this.btnAgregarLugar.UseVisualStyleBackColor = false;
            this.btnAgregarLugar.Click += new System.EventHandler(this.btnAgregarLugar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox5.Controls.Add(this.cmbLugar);
            this.groupBox5.Controls.Add(this.txtNombreLugar);
            this.groupBox5.Controls.Add(this.btnAgregarTarea);
            this.groupBox5.Location = new System.Drawing.Point(0, 122);
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
            this.btnAgregarTarea.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAgregarTarea.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTarea.Image")));
            this.btnAgregarTarea.Location = new System.Drawing.Point(159, 47);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(36, 34);
            this.btnAgregarTarea.TabIndex = 17;
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(244, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 40);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvGrilla2
            // 
            this.dgvGrilla2.AllowDrop = true;
            this.dgvGrilla2.AllowUserToAddRows = false;
            this.dgvGrilla2.AllowUserToDeleteRows = false;
            this.dgvGrilla2.AllowUserToResizeColumns = false;
            this.dgvGrilla2.AllowUserToResizeRows = false;
            this.dgvGrilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla2.Location = new System.Drawing.Point(503, 188);
            this.dgvGrilla2.MultiSelect = false;
            this.dgvGrilla2.Name = "dgvGrilla2";
            this.dgvGrilla2.ReadOnly = true;
            this.dgvGrilla2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla2.Size = new System.Drawing.Size(807, 261);
            this.dgvGrilla2.TabIndex = 23;
            // 
            // grbID
            // 
            this.grbID.BackColor = System.Drawing.SystemColors.Window;
            this.grbID.Controls.Add(this.label1);
            this.grbID.Controls.Add(this.cmbTabla);
            this.grbID.Controls.Add(this.btnDesacer);
            this.grbID.Controls.Add(this.numBuscarId);
            this.grbID.Controls.Add(this.lblID);
            this.grbID.Controls.Add(this.btnSalir);
            this.grbID.Location = new System.Drawing.Point(1052, 3);
            this.grbID.Name = "grbID";
            this.grbID.Size = new System.Drawing.Size(208, 106);
            this.grbID.TabIndex = 25;
            this.grbID.TabStop = false;
            this.grbID.Text = "Buscar TareaCompleta";
            // 
            // numBuscarId
            // 
            this.numBuscarId.Location = new System.Drawing.Point(41, 27);
            this.numBuscarId.Name = "numBuscarId";
            this.numBuscarId.Size = new System.Drawing.Size(100, 20);
            this.numBuscarId.TabIndex = 21;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(147, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 45);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDesacer
            // 
            this.btnDesacer.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDesacer.Image = ((System.Drawing.Image)(resources.GetObject("btnDesacer.Image")));
            this.btnDesacer.Location = new System.Drawing.Point(147, 60);
            this.btnDesacer.Name = "btnDesacer";
            this.btnDesacer.Size = new System.Drawing.Size(52, 45);
            this.btnDesacer.TabIndex = 26;
            this.btnDesacer.UseVisualStyleBackColor = false;
            this.btnDesacer.Click += new System.EventHandler(this.btnDesacer_Click);
            // 
            // cmbTabla
            // 
            this.cmbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Location = new System.Drawing.Point(41, 65);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(100, 21);
            this.cmbTabla.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tabla";
            // 
            // frmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 471);
            this.Controls.Add(this.grbID);
            this.Controls.Add(this.dgvGrilla);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla2)).EndInit();
            this.grbID.ResumeLayout(false);
            this.grbID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuscarId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.RadioButton optTiempoLargo;
        private System.Windows.Forms.RadioButton optTiempoCorto;
        private System.Windows.Forms.RadioButton optPendiente;
        private System.Windows.Forms.RadioButton optEfectuado;
        private System.Windows.Forms.Button btnCargarCompleta;
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
        private System.Windows.Forms.GroupBox grbID;
        private System.Windows.Forms.NumericUpDown numBuscarId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDesacer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTabla;
    }
}