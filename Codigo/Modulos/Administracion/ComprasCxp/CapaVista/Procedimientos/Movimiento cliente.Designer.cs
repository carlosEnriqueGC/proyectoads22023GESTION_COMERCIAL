﻿
namespace CapaVista.Procedimientos
{
    partial class Movimiento_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movimiento_cliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_fechaEmision = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_conceptoValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_serieConcepto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tipoConcepto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_busquedaCliente = new System.Windows.Forms.Button();
            this.btn_Busqueda = new System.Windows.Forms.Button();
            this.cb_busquedaConcepto = new System.Windows.Forms.ComboBox();
            this.cb_busquedaCliente = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtTabla = new System.Windows.Forms.DataGridView();
            this.txt_eliminacion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_fechaEmision);
            this.groupBox1.Controls.Add(this.dtp_fechaVencimiento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_tipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_estado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(981, 134);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dato cliente";
            // 
            // dtp_fechaEmision
            // 
            this.dtp_fechaEmision.Location = new System.Drawing.Point(432, 82);
            this.dtp_fechaEmision.Name = "dtp_fechaEmision";
            this.dtp_fechaEmision.Size = new System.Drawing.Size(193, 22);
            this.dtp_fechaEmision.TabIndex = 31;
            this.dtp_fechaEmision.Value = new System.DateTime(2023, 10, 27, 0, 0, 0, 0);
            // 
            // dtp_fechaVencimiento
            // 
            this.dtp_fechaVencimiento.Location = new System.Drawing.Point(735, 39);
            this.dtp_fechaVencimiento.Name = "dtp_fechaVencimiento";
            this.dtp_fechaVencimiento.Size = new System.Drawing.Size(200, 22);
            this.dtp_fechaVencimiento.TabIndex = 30;
            this.dtp_fechaVencimiento.Value = new System.DateTime(2023, 10, 27, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha Emision";
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(433, 39);
            this.txt_tipo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(192, 22);
            this.txt_tipo.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tipo";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(74, 80);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(192, 22);
            this.txt_estado.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Estado";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(74, 37);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(192, 22);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_conceptoValor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_aceptar);
            this.groupBox2.Controls.Add(this.txt_serieConcepto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_tipoConcepto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_concepto);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(13, 265);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(981, 110);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del movimiento";
            // 
            // txt_conceptoValor
            // 
            this.txt_conceptoValor.Location = new System.Drawing.Point(596, 65);
            this.txt_conceptoValor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_conceptoValor.Name = "txt_conceptoValor";
            this.txt_conceptoValor.Size = new System.Drawing.Size(151, 22);
            this.txt_conceptoValor.TabIndex = 30;
            this.txt_conceptoValor.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Valor";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.BackgroundImage")));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Location = new System.Drawing.Point(900, 29);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(50, 47);
            this.btn_aceptar.TabIndex = 28;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_serieConcepto
            // 
            this.txt_serieConcepto.Location = new System.Drawing.Point(397, 65);
            this.txt_serieConcepto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_serieConcepto.Name = "txt_serieConcepto";
            this.txt_serieConcepto.Size = new System.Drawing.Size(151, 22);
            this.txt_serieConcepto.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Serie del concepto";
            // 
            // txt_tipoConcepto
            // 
            this.txt_tipoConcepto.Location = new System.Drawing.Point(237, 65);
            this.txt_tipoConcepto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tipoConcepto.Name = "txt_tipoConcepto";
            this.txt_tipoConcepto.Size = new System.Drawing.Size(115, 22);
            this.txt_tipoConcepto.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo";
            // 
            // txt_concepto
            // 
            this.txt_concepto.Location = new System.Drawing.Point(8, 65);
            this.txt_concepto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(192, 22);
            this.txt_concepto.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Concepto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_busquedaCliente);
            this.groupBox3.Controls.Add(this.btn_Busqueda);
            this.groupBox3.Controls.Add(this.cb_busquedaConcepto);
            this.groupBox3.Controls.Add(this.cb_busquedaCliente);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(981, 79);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda de datos";
            // 
            // btn_busquedaCliente
            // 
            this.btn_busquedaCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_busquedaCliente.BackgroundImage")));
            this.btn_busquedaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busquedaCliente.Location = new System.Drawing.Point(223, 25);
            this.btn_busquedaCliente.Name = "btn_busquedaCliente";
            this.btn_busquedaCliente.Size = new System.Drawing.Size(50, 47);
            this.btn_busquedaCliente.TabIndex = 30;
            this.btn_busquedaCliente.UseVisualStyleBackColor = true;
            this.btn_busquedaCliente.Click += new System.EventHandler(this.btn_busquedaCliente_Click);
            // 
            // btn_Busqueda
            // 
            this.btn_Busqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Busqueda.BackgroundImage")));
            this.btn_Busqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Busqueda.Location = new System.Drawing.Point(635, 26);
            this.btn_Busqueda.Name = "btn_Busqueda";
            this.btn_Busqueda.Size = new System.Drawing.Size(50, 47);
            this.btn_Busqueda.TabIndex = 28;
            this.btn_Busqueda.UseVisualStyleBackColor = true;
            this.btn_Busqueda.Click += new System.EventHandler(this.btn_Busqueda_Click);
            // 
            // cb_busquedaConcepto
            // 
            this.cb_busquedaConcepto.FormattingEnabled = true;
            this.cb_busquedaConcepto.Location = new System.Drawing.Point(491, 37);
            this.cb_busquedaConcepto.Name = "cb_busquedaConcepto";
            this.cb_busquedaConcepto.Size = new System.Drawing.Size(121, 24);
            this.cb_busquedaConcepto.TabIndex = 26;
            // 
            // cb_busquedaCliente
            // 
            this.cb_busquedaCliente.FormattingEnabled = true;
            this.cb_busquedaCliente.Location = new System.Drawing.Point(74, 37);
            this.cb_busquedaCliente.Name = "cb_busquedaCliente";
            this.cb_busquedaCliente.Size = new System.Drawing.Size(121, 24);
            this.cb_busquedaCliente.TabIndex = 25;
            this.cb_busquedaCliente.SelectedIndexChanged += new System.EventHandler(this.cb_busquedaCliente_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Concepto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Cliente";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(913, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 44);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(426, 673);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(71, 22);
            this.textBox9.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 673);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Total";
            // 
            // dtTabla
            // 
            this.dtTabla.AllowUserToAddRows = false;
            this.dtTabla.AllowUserToDeleteRows = false;
            this.dtTabla.AllowUserToResizeColumns = false;
            this.dtTabla.AllowUserToResizeRows = false;
            this.dtTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtTabla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtTabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtTabla.Location = new System.Drawing.Point(13, 396);
            this.dtTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dtTabla.Name = "dtTabla";
            this.dtTabla.ReadOnly = true;
            this.dtTabla.RowHeadersVisible = false;
            this.dtTabla.RowHeadersWidth = 51;
            this.dtTabla.Size = new System.Drawing.Size(864, 248);
            this.dtTabla.TabIndex = 42;
            // 
            // txt_eliminacion
            // 
            this.txt_eliminacion.Location = new System.Drawing.Point(898, 491);
            this.txt_eliminacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_eliminacion.Name = "txt_eliminacion";
            this.txt_eliminacion.Size = new System.Drawing.Size(96, 22);
            this.txt_eliminacion.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(895, 457);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "ID movimiento";
            // 
            // Movimiento_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 710);
            this.Controls.Add(this.txt_eliminacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtTabla);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Movimiento_cliente";
            this.Text = "Movimiento_cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_serieConcepto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tipoConcepto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_Busqueda;
        private System.Windows.Forms.ComboBox cb_busquedaConcepto;
        private System.Windows.Forms.ComboBox cb_busquedaCliente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_conceptoValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtTabla;
        private System.Windows.Forms.Button btn_busquedaCliente;
        private System.Windows.Forms.DateTimePicker dtp_fechaEmision;
        private System.Windows.Forms.DateTimePicker dtp_fechaVencimiento;
        private System.Windows.Forms.TextBox txt_eliminacion;
        private System.Windows.Forms.Label label12;
    }
}