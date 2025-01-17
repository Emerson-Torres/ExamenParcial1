﻿namespace SistemaInventario
{
    partial class FrmTrabajadores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrabajadores));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBSalir = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnimportar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvmostrar = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.fechanacimiento = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.txtseguro = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtafp = new System.Windows.Forms.MaskedTextBox();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtdui = new System.Windows.Forms.MaskedTextBox();
            this.txtni = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnexportar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajadores";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(164)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.picBMinimizar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.picBSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 60);
            this.panel1.TabIndex = 1;
            // 
            // picBMinimizar
            // 
            this.picBMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBMinimizar.Image")));
            this.picBMinimizar.Location = new System.Drawing.Point(1028, 9);
            this.picBMinimizar.Name = "picBMinimizar";
            this.picBMinimizar.Size = new System.Drawing.Size(45, 42);
            this.picBMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMinimizar.TabIndex = 30;
            this.picBMinimizar.TabStop = false;
            this.picBMinimizar.Click += new System.EventHandler(this.picBMinimizar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-22, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // picBSalir
            // 
            this.picBSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBSalir.Image = ((System.Drawing.Image)(resources.GetObject("picBSalir.Image")));
            this.picBSalir.Location = new System.Drawing.Point(1079, 9);
            this.picBSalir.Name = "picBSalir";
            this.picBSalir.Size = new System.Drawing.Size(40, 42);
            this.picBSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBSalir.TabIndex = 26;
            this.picBSalir.TabStop = false;
            this.picBSalir.Click += new System.EventHandler(this.picBSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "DUI:";
            // 
            // txtnit
            // 
            this.txtnit.AutoSize = true;
            this.txtnit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnit.ForeColor = System.Drawing.Color.Black;
            this.txtnit.Location = new System.Drawing.Point(8, 88);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(37, 22);
            this.txtnit.TabIndex = 27;
            this.txtnit.Text = "NIT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "AFP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "Numero de telefono:";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(216, 6);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(229, 27);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.Location = new System.Drawing.Point(7, 450);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(133, 34);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Guardar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.Color.Black;
            this.btnborrar.Location = new System.Drawing.Point(166, 450);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(133, 35);
            this.btnborrar.TabIndex = 1;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnimportar
            // 
            this.btnimportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnimportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnimportar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportar.ForeColor = System.Drawing.Color.Black;
            this.btnimportar.Location = new System.Drawing.Point(496, 450);
            this.btnimportar.Name = "btnimportar";
            this.btnimportar.Size = new System.Drawing.Size(133, 35);
            this.btnimportar.TabIndex = 3;
            this.btnimportar.Text = "Importar";
            this.btnimportar.UseVisualStyleBackColor = false;
            this.btnimportar.Click += new System.EventHandler(this.btnimportar_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(1023, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 22);
            this.label12.TabIndex = 27;
            this.label12.Text = "Registro de alumnos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvmostrar
            // 
            this.dgvmostrar.AllowUserToAddRows = false;
            this.dgvmostrar.AllowUserToDeleteRows = false;
            this.dgvmostrar.AllowUserToOrderColumns = true;
            this.dgvmostrar.AllowUserToResizeRows = false;
            this.dgvmostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrar.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvmostrar.Location = new System.Drawing.Point(7, 44);
            this.dgvmostrar.MultiSelect = false;
            this.dgvmostrar.Name = "dgvmostrar";
            this.dgvmostrar.ReadOnly = true;
            this.dgvmostrar.RowHeadersWidth = 51;
            this.dgvmostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmostrar.Size = new System.Drawing.Size(622, 380);
            this.dgvmostrar.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.fechanacimiento);
            this.panel2.Controls.Add(this.cbtipo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtpago);
            this.panel2.Controls.Add(this.txtseguro);
            this.panel2.Controls.Add(this.txtdireccion);
            this.panel2.Controls.Add(this.txtafp);
            this.panel2.Controls.Add(this.txttelefono);
            this.panel2.Controls.Add(this.txtdui);
            this.panel2.Controls.Add(this.txtni);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtnit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtnombre);
            this.panel2.Location = new System.Drawing.Point(12, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 569);
            this.panel2.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 22);
            this.label9.TabIndex = 65;
            this.label9.Text = "Fecha de nacimiento:";
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.Location = new System.Drawing.Point(216, 386);
            this.fechanacimiento.Margin = new System.Windows.Forms.Padding(7);
            this.fechanacimiento.MaxDate = new System.DateTime(2021, 3, 24, 14, 25, 5, 0);
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 61;
            this.label8.Text = "Seguro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 60;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "Pago por dia:";
            // 
            // txtpago
            // 
            this.txtpago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpago.Location = new System.Drawing.Point(216, 305);
            this.txtpago.MaxLength = 50;
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(229, 27);
            this.txtpago.TabIndex = 7;
            // 
            // txtseguro
            // 
            this.txtseguro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtseguro.Location = new System.Drawing.Point(216, 217);
            this.txtseguro.MaxLength = 50;
            this.txtseguro.Name = "txtseguro";
            this.txtseguro.Size = new System.Drawing.Size(229, 27);
            this.txtseguro.TabIndex = 5;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(216, 261);
            this.txtdireccion.MaxLength = 50;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(229, 27);
            this.txtdireccion.TabIndex = 6;
            // 
            // txtafp
            // 
            this.txtafp.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtafp.Location = new System.Drawing.Point(216, 133);
            this.txtafp.Margin = new System.Windows.Forms.Padding(2);
            this.txtafp.Mask = "000000000000";
            this.txtafp.Name = "txtafp";
            this.txtafp.Size = new System.Drawing.Size(229, 27);
            this.txtafp.TabIndex = 3;
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txttelefono.Location = new System.Drawing.Point(216, 176);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefono.Mask = "0000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(229, 27);
            this.txttelefono.TabIndex = 4;
            // 
            // txtdui
            // 
            this.txtdui.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtdui.Location = new System.Drawing.Point(216, 46);
            this.txtdui.Margin = new System.Windows.Forms.Padding(2);
            this.txtdui.Mask = "00000000-0";
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(229, 27);
            this.txtdui.TabIndex = 1;
            this.txtdui.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtni
            // 
            this.txtni.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtni.Location = new System.Drawing.Point(216, 86);
            this.txtni.Margin = new System.Windows.Forms.Padding(2);
            this.txtni.Mask = "0000-000000-000-0";
            this.txtni.Name = "txtni";
            this.txtni.Size = new System.Drawing.Size(229, 27);
            this.txtni.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 51;
            this.label4.Text = "Nombre Archivo:";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo.Location = new System.Drawing.Point(166, 528);
            this.txtArchivo.MaxLength = 100;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(300, 27);
            this.txtArchivo.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnexportar);
            this.panel3.Controls.Add(this.dgvmostrar);
            this.panel3.Controls.Add(this.btnimportar);
            this.panel3.Controls.Add(this.btnagregar);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnborrar);
            this.panel3.Controls.Add(this.txtArchivo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(480, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 567);
            this.panel3.TabIndex = 42;
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexportar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.ForeColor = System.Drawing.Color.Black;
            this.btnexportar.Location = new System.Drawing.Point(333, 450);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(133, 35);
            this.btnexportar.TabIndex = 2;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(394, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(235, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Registro de trabajadores";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // cbtipo
            // 
            this.cbtipo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Trabajador",
            "Secretari@",
            "Auxiliar"});
            this.cbtipo.Location = new System.Drawing.Point(216, 344);
            this.cbtipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(229, 29);
            this.cbtipo.TabIndex = 8;
            // 
            // FrmTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTrabajadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajadores";
            this.Load += new System.EventHandler(this.FrmTrabajadores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnimportar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvmostrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBMinimizar;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.MaskedTextBox txtni;
        private System.Windows.Forms.MaskedTextBox txtdui;
        private System.Windows.Forms.MaskedTextBox txtafp;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.TextBox txtseguro;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.MonthCalendar fechanacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbtipo;
    }
}