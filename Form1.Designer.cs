namespace PruebaABB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbPostOrden = new System.Windows.Forms.RadioButton();
            this.rdbInOrden = new System.Windows.Forms.RadioButton();
            this.rdbPreOrden = new System.Windows.Forms.RadioButton();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.TCampo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCampo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCampo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCampo4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCampo5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCampo6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCampo7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCampo8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCampo9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFacil = new System.Windows.Forms.Button();
            this.lblC8 = new System.Windows.Forms.GroupBox();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxSeguro = new System.Windows.Forms.CheckBox();
            this.lblC7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCampo6 = new System.Windows.Forms.ComboBox();
            this.txtCampo4 = new System.Windows.Forms.TextBox();
            this.txtCampo3 = new System.Windows.Forms.TextBox();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
            this.txtCampo1 = new System.Windows.Forms.TextBox();
            this.lblC6 = new System.Windows.Forms.Label();
            this.lblC5 = new System.Windows.Forms.Label();
            this.lblC4 = new System.Windows.Forms.Label();
            this.lblC3 = new System.Windows.Forms.Label();
            this.lblC2 = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pcbGrafico = new System.Windows.Forms.PictureBox();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.chbBuscar = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.lblC8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbPostOrden);
            this.groupBox3.Controls.Add(this.rdbInOrden);
            this.groupBox3.Controls.Add(this.rdbPreOrden);
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 178);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de recorrido y desplege de datos";
            // 
            // rdbPostOrden
            // 
            this.rdbPostOrden.AutoSize = true;
            this.rdbPostOrden.Location = new System.Drawing.Point(29, 124);
            this.rdbPostOrden.Name = "rdbPostOrden";
            this.rdbPostOrden.Size = new System.Drawing.Size(75, 17);
            this.rdbPostOrden.TabIndex = 13;
            this.rdbPostOrden.TabStop = true;
            this.rdbPostOrden.Text = "PostOrden";
            this.rdbPostOrden.UseVisualStyleBackColor = true;
            // 
            // rdbInOrden
            // 
            this.rdbInOrden.AutoSize = true;
            this.rdbInOrden.Location = new System.Drawing.Point(29, 79);
            this.rdbInOrden.Name = "rdbInOrden";
            this.rdbInOrden.Size = new System.Drawing.Size(63, 17);
            this.rdbInOrden.TabIndex = 0;
            this.rdbInOrden.TabStop = true;
            this.rdbInOrden.Text = "InOrden";
            this.rdbInOrden.UseVisualStyleBackColor = true;
            // 
            // rdbPreOrden
            // 
            this.rdbPreOrden.AutoSize = true;
            this.rdbPreOrden.Location = new System.Drawing.Point(29, 34);
            this.rdbPreOrden.Name = "rdbPreOrden";
            this.rdbPreOrden.Size = new System.Drawing.Size(70, 17);
            this.rdbPreOrden.TabIndex = 12;
            this.rdbPreOrden.TabStop = true;
            this.rdbPreOrden.Text = "PreOrden";
            this.rdbPreOrden.UseVisualStyleBackColor = true;
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TCampo1,
            this.TCampo2,
            this.TCampo3,
            this.TCampo4,
            this.TCampo5,
            this.TCampo6,
            this.TCampo7,
            this.TCampo8,
            this.TCampo9});
            this.Tabla.Location = new System.Drawing.Point(236, 286);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(609, 178);
            this.Tabla.TabIndex = 11;
            this.Tabla.Click += new System.EventHandler(this.clickdata);
            // 
            // TCampo1
            // 
            this.TCampo1.HeaderText = "Campo1";
            this.TCampo1.Name = "TCampo1";
            this.TCampo1.ReadOnly = true;
            // 
            // TCampo2
            // 
            this.TCampo2.HeaderText = "Campo2";
            this.TCampo2.Name = "TCampo2";
            this.TCampo2.ReadOnly = true;
            // 
            // TCampo3
            // 
            this.TCampo3.HeaderText = "Campo3";
            this.TCampo3.Name = "TCampo3";
            this.TCampo3.ReadOnly = true;
            // 
            // TCampo4
            // 
            this.TCampo4.HeaderText = "Campo4";
            this.TCampo4.Name = "TCampo4";
            this.TCampo4.ReadOnly = true;
            // 
            // TCampo5
            // 
            this.TCampo5.HeaderText = "Campo5";
            this.TCampo5.Name = "TCampo5";
            this.TCampo5.ReadOnly = true;
            // 
            // TCampo6
            // 
            this.TCampo6.HeaderText = "Campo6";
            this.TCampo6.Name = "TCampo6";
            this.TCampo6.ReadOnly = true;
            // 
            // TCampo7
            // 
            this.TCampo7.HeaderText = "Campo7";
            this.TCampo7.Name = "TCampo7";
            this.TCampo7.ReadOnly = true;
            // 
            // TCampo8
            // 
            this.TCampo8.HeaderText = "Campo8";
            this.TCampo8.Name = "TCampo8";
            this.TCampo8.ReadOnly = true;
            // 
            // TCampo9
            // 
            this.TCampo9.HeaderText = "Campo9";
            this.TCampo9.Name = "TCampo9";
            this.TCampo9.ReadOnly = true;
            this.TCampo9.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFacil);
            this.groupBox2.Controls.Add(this.lblC8);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.cbxSeguro);
            this.groupBox2.Controls.Add(this.lblC7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbCampo6);
            this.groupBox2.Controls.Add(this.txtCampo4);
            this.groupBox2.Controls.Add(this.txtCampo3);
            this.groupBox2.Controls.Add(this.txtCampo2);
            this.groupBox2.Controls.Add(this.txtCampo1);
            this.groupBox2.Controls.Add(this.lblC6);
            this.groupBox2.Controls.Add(this.lblC5);
            this.groupBox2.Controls.Add(this.lblC4);
            this.groupBox2.Controls.Add(this.lblC3);
            this.groupBox2.Controls.Add(this.lblC2);
            this.groupBox2.Controls.Add(this.lblC1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 203);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // btnFacil
            // 
            this.btnFacil.Location = new System.Drawing.Point(327, 90);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(24, 23);
            this.btnFacil.TabIndex = 37;
            this.btnFacil.Text = "?";
            this.btnFacil.UseVisualStyleBackColor = true;
            this.btnFacil.Click += new System.EventHandler(this.btnFacil_Click_1);
            // 
            // lblC8
            // 
            this.lblC8.Controls.Add(this.rdbMujer);
            this.lblC8.Controls.Add(this.rdbHombre);
            this.lblC8.Location = new System.Drawing.Point(224, 10);
            this.lblC8.Name = "lblC8";
            this.lblC8.Size = new System.Drawing.Size(127, 76);
            this.lblC8.TabIndex = 36;
            this.lblC8.TabStop = false;
            this.lblC8.Text = "Sexo del empleado/a";
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Location = new System.Drawing.Point(6, 42);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(71, 17);
            this.rdbMujer.TabIndex = 1;
            this.rdbMujer.TabStop = true;
            this.rdbMujer.Text = "Femenino";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Location = new System.Drawing.Point(6, 19);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(73, 17);
            this.rdbHombre.TabIndex = 0;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Masculino";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(108, 120);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 35;
            // 
            // cbxSeguro
            // 
            this.cbxSeguro.AutoSize = true;
            this.cbxSeguro.Location = new System.Drawing.Point(128, 173);
            this.cbxSeguro.Name = "cbxSeguro";
            this.cbxSeguro.Size = new System.Drawing.Size(35, 17);
            this.cbxSeguro.TabIndex = 29;
            this.cbxSeguro.Text = "Si";
            this.cbxSeguro.UseVisualStyleBackColor = true;
            // 
            // lblC7
            // 
            this.lblC7.AutoSize = true;
            this.lblC7.Location = new System.Drawing.Point(11, 174);
            this.lblC7.Name = "lblC7";
            this.lblC7.Size = new System.Drawing.Size(81, 13);
            this.lblC7.TabIndex = 28;
            this.lblC7.Text = "¿Tiene seguro?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Puesto en el que labora";
            // 
            // cmbCampo6
            // 
            this.cmbCampo6.FormattingEnabled = true;
            this.cmbCampo6.Location = new System.Drawing.Point(108, 146);
            this.cmbCampo6.Name = "cmbCampo6";
            this.cmbCampo6.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo6.TabIndex = 7;
            // 
            // txtCampo4
            // 
            this.txtCampo4.Location = new System.Drawing.Point(108, 93);
            this.txtCampo4.Name = "txtCampo4";
            this.txtCampo4.Size = new System.Drawing.Size(100, 20);
            this.txtCampo4.TabIndex = 9;
            // 
            // txtCampo3
            // 
            this.txtCampo3.Location = new System.Drawing.Point(108, 66);
            this.txtCampo3.Name = "txtCampo3";
            this.txtCampo3.Size = new System.Drawing.Size(100, 20);
            this.txtCampo3.TabIndex = 8;
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(168, 39);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(40, 20);
            this.txtCampo2.TabIndex = 7;
            // 
            // txtCampo1
            // 
            this.txtCampo1.Location = new System.Drawing.Point(108, 13);
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(100, 20);
            this.txtCampo1.TabIndex = 6;
            // 
            // lblC6
            // 
            this.lblC6.AutoSize = true;
            this.lblC6.Location = new System.Drawing.Point(8, 149);
            this.lblC6.Name = "lblC6";
            this.lblC6.Size = new System.Drawing.Size(35, 13);
            this.lblC6.TabIndex = 5;
            this.lblC6.Text = "label6";
            // 
            // lblC5
            // 
            this.lblC5.AutoSize = true;
            this.lblC5.Location = new System.Drawing.Point(8, 123);
            this.lblC5.Name = "lblC5";
            this.lblC5.Size = new System.Drawing.Size(35, 13);
            this.lblC5.TabIndex = 4;
            this.lblC5.Text = "label5";
            // 
            // lblC4
            // 
            this.lblC4.AutoSize = true;
            this.lblC4.Location = new System.Drawing.Point(7, 96);
            this.lblC4.Name = "lblC4";
            this.lblC4.Size = new System.Drawing.Size(35, 13);
            this.lblC4.TabIndex = 3;
            this.lblC4.Text = "label4";
            // 
            // lblC3
            // 
            this.lblC3.AutoSize = true;
            this.lblC3.Location = new System.Drawing.Point(8, 69);
            this.lblC3.Name = "lblC3";
            this.lblC3.Size = new System.Drawing.Size(35, 13);
            this.lblC3.TabIndex = 2;
            this.lblC3.Text = "label3";
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.Location = new System.Drawing.Point(7, 43);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(35, 13);
            this.lblC2.TabIndex = 1;
            this.lblC2.Text = "label2";
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.Location = new System.Drawing.Point(9, 20);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(35, 13);
            this.lblC1.TabIndex = 0;
            this.lblC1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.btnDibujar);
            this.groupBox1.Controls.Add(this.btnRecorrer);
            this.groupBox1.Controls.Add(this.btnVaciar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(733, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 263);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(17, 234);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(6, 199);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 32);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar Aleatorio";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(17, 169);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 7;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click_1);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(17, 139);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrer.TabIndex = 6;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(17, 109);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 23);
            this.btnVaciar.TabIndex = 5;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(17, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(17, 49);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // pcbGrafico
            // 
            this.pcbGrafico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbGrafico.Location = new System.Drawing.Point(543, 12);
            this.pcbGrafico.Name = "pcbGrafico";
            this.pcbGrafico.Size = new System.Drawing.Size(175, 257);
            this.pcbGrafico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGrafico.TabIndex = 8;
            this.pcbGrafico.TabStop = false;
            // 
            // pcbImagen
            // 
            this.pcbImagen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pcbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pcbImagen.Image")));
            this.pcbImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbImagen.InitialImage")));
            this.pcbImagen.Location = new System.Drawing.Point(376, 12);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(161, 257);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 7;
            this.pcbImagen.TabStop = false;
            this.pcbImagen.Click += new System.EventHandler(this.pcbImagen_Click);
            // 
            // chbBuscar
            // 
            this.chbBuscar.AutoSize = true;
            this.chbBuscar.Location = new System.Drawing.Point(41, 220);
            this.chbBuscar.Name = "chbBuscar";
            this.chbBuscar.Size = new System.Drawing.Size(263, 17);
            this.chbBuscar.TabIndex = 13;
            this.chbBuscar.Text = "¿Desea buscar pulsando un elemento de la tabla?";
            this.chbBuscar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 476);
            this.Controls.Add(this.chbBuscar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbGrafico);
            this.Controls.Add(this.pcbImagen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.lblC8.ResumeLayout(false);
            this.lblC8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbPostOrden;
        private System.Windows.Forms.RadioButton rdbInOrden;
        private System.Windows.Forms.RadioButton rdbPreOrden;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCampo9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFacil;
        private System.Windows.Forms.GroupBox lblC8;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox cbxSeguro;
        private System.Windows.Forms.Label lblC7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCampo6;
        private System.Windows.Forms.TextBox txtCampo4;
        private System.Windows.Forms.TextBox txtCampo3;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.TextBox txtCampo1;
        private System.Windows.Forms.Label lblC6;
        private System.Windows.Forms.Label lblC5;
        private System.Windows.Forms.Label lblC4;
        private System.Windows.Forms.Label lblC3;
        private System.Windows.Forms.Label lblC2;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pcbGrafico;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.CheckBox chbBuscar;
    }
}

