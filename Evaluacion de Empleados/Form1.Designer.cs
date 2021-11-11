
namespace Evaluacion_de_Empleados
{
    partial class frm_registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_planilla = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.lb_nac = new System.Windows.Forms.Label();
            this.lb_contrato = new System.Windows.Forms.Label();
            this.lb_sueldo = new System.Windows.Forms.Label();
            this.lb_isss = new System.Windows.Forms.Label();
            this.lb_renta = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_sueldoi = new System.Windows.Forms.TextBox();
            this.dtp_nac = new System.Windows.Forms.DateTimePicker();
            this.dtp_contrato = new System.Windows.Forms.DateTimePicker();
            this.nud_isss = new System.Windows.Forms.NumericUpDown();
            this.nud_renta = new System.Windows.Forms.NumericUpDown();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_dui = new System.Windows.Forms.TextBox();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.lb_dui = new System.Windows.Forms.Label();
            this.lb_cel = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_isss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_renta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_planilla
            // 
            this.dgv_planilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_planilla.Location = new System.Drawing.Point(28, 336);
            this.dgv_planilla.Name = "dgv_planilla";
            this.dgv_planilla.RowHeadersWidth = 51;
            this.dgv_planilla.RowTemplate.Height = 29;
            this.dgv_planilla.Size = new System.Drawing.Size(1076, 263);
            this.dgv_planilla.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lb_cel);
            this.groupBox1.Controls.Add(this.lb_dui);
            this.groupBox1.Controls.Add(this.txt_cel);
            this.groupBox1.Controls.Add(this.txt_dui);
            this.groupBox1.Controls.Add(this.dtp_nac);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.lb_nac);
            this.groupBox1.Controls.Add(this.lb_apellido);
            this.groupBox1.Controls.Add(this.lb_nombre);
            this.groupBox1.Location = new System.Drawing.Point(28, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.nud_renta);
            this.groupBox2.Controls.Add(this.nud_isss);
            this.groupBox2.Controls.Add(this.dtp_contrato);
            this.groupBox2.Controls.Add(this.txt_sueldoi);
            this.groupBox2.Controls.Add(this.lb_renta);
            this.groupBox2.Controls.Add(this.lb_isss);
            this.groupBox2.Controls.Add(this.lb_sueldo);
            this.groupBox2.Controls.Add(this.lb_contrato);
            this.groupBox2.Location = new System.Drawing.Point(553, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 208);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Laborales";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(17, 29);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(73, 20);
            this.lb_nombre.TabIndex = 0;
            this.lb_nombre.Text = "Nombres:";
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Location = new System.Drawing.Point(17, 68);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(75, 20);
            this.lb_apellido.TabIndex = 1;
            this.lb_apellido.Text = "Apellidos:";
            // 
            // lb_nac
            // 
            this.lb_nac.AutoSize = true;
            this.lb_nac.Location = new System.Drawing.Point(17, 110);
            this.lb_nac.Name = "lb_nac";
            this.lb_nac.Size = new System.Drawing.Size(128, 20);
            this.lb_nac.TabIndex = 2;
            this.lb_nac.Text = "Fecha nacimiento:";
            // 
            // lb_contrato
            // 
            this.lb_contrato.AutoSize = true;
            this.lb_contrato.Location = new System.Drawing.Point(21, 34);
            this.lb_contrato.Name = "lb_contrato";
            this.lb_contrato.Size = new System.Drawing.Size(110, 20);
            this.lb_contrato.TabIndex = 0;
            this.lb_contrato.Text = "Fecha contrato:";
            // 
            // lb_sueldo
            // 
            this.lb_sueldo.AutoSize = true;
            this.lb_sueldo.Location = new System.Drawing.Point(21, 88);
            this.lb_sueldo.Name = "lb_sueldo";
            this.lb_sueldo.Size = new System.Drawing.Size(93, 20);
            this.lb_sueldo.TabIndex = 1;
            this.lb_sueldo.Text = "Sueldo Base:";
            // 
            // lb_isss
            // 
            this.lb_isss.AutoSize = true;
            this.lb_isss.Location = new System.Drawing.Point(21, 153);
            this.lb_isss.Name = "lb_isss";
            this.lb_isss.Size = new System.Drawing.Size(72, 20);
            this.lb_isss.TabIndex = 2;
            this.lb_isss.Text = "Tasa ISSS:";
            // 
            // lb_renta
            // 
            this.lb_renta.AutoSize = true;
            this.lb_renta.Location = new System.Drawing.Point(291, 89);
            this.lb_renta.Name = "lb_renta";
            this.lb_renta.Size = new System.Drawing.Size(82, 20);
            this.lb_renta.TabIndex = 3;
            this.lb_renta.Text = "Tasa Renta:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(151, 27);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(236, 27);
            this.txt_nombre.TabIndex = 3;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(151, 65);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(236, 27);
            this.txt_apellido.TabIndex = 4;
            // 
            // txt_sueldoi
            // 
            this.txt_sueldoi.Location = new System.Drawing.Point(120, 86);
            this.txt_sueldoi.Name = "txt_sueldoi";
            this.txt_sueldoi.Size = new System.Drawing.Size(150, 27);
            this.txt_sueldoi.TabIndex = 4;
            // 
            // dtp_nac
            // 
            this.dtp_nac.Location = new System.Drawing.Point(151, 103);
            this.dtp_nac.Name = "dtp_nac";
            this.dtp_nac.Size = new System.Drawing.Size(320, 27);
            this.dtp_nac.TabIndex = 5;
            // 
            // dtp_contrato
            // 
            this.dtp_contrato.Location = new System.Drawing.Point(137, 29);
            this.dtp_contrato.Name = "dtp_contrato";
            this.dtp_contrato.Size = new System.Drawing.Size(403, 27);
            this.dtp_contrato.TabIndex = 5;
            // 
            // nud_isss
            // 
            this.nud_isss.DecimalPlaces = 1;
            this.nud_isss.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_isss.Location = new System.Drawing.Point(120, 151);
            this.nud_isss.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_isss.Name = "nud_isss";
            this.nud_isss.Size = new System.Drawing.Size(150, 27);
            this.nud_isss.TabIndex = 6;
            // 
            // nud_renta
            // 
            this.nud_renta.DecimalPlaces = 1;
            this.nud_renta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_renta.Location = new System.Drawing.Point(390, 86);
            this.nud_renta.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_renta.Name = "nud_renta";
            this.nud_renta.Size = new System.Drawing.Size(150, 27);
            this.nud_renta.TabIndex = 7;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.Location = new System.Drawing.Point(309, 272);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(180, 46);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Proximo Empleado";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_abrir
            // 
            this.btn_abrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_abrir.Location = new System.Drawing.Point(625, 272);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(177, 46);
            this.btn_abrir.TabIndex = 5;
            this.btn_abrir.Text = "Abrir Planilla";
            this.btn_abrir.UseVisualStyleBackColor = true;
            // 
            // btn_generar
            // 
            this.btn_generar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generar.Location = new System.Drawing.Point(851, 272);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(175, 46);
            this.btn_generar.TabIndex = 6;
            this.btn_generar.Text = "Generar Planilla";
            this.btn_generar.UseVisualStyleBackColor = true;
            // 
            // txt_dui
            // 
            this.txt_dui.Location = new System.Drawing.Point(60, 150);
            this.txt_dui.Name = "txt_dui";
            this.txt_dui.Size = new System.Drawing.Size(141, 27);
            this.txt_dui.TabIndex = 6;
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(301, 150);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(170, 27);
            this.txt_cel.TabIndex = 7;
            // 
            // lb_dui
            // 
            this.lb_dui.AutoSize = true;
            this.lb_dui.Location = new System.Drawing.Point(17, 153);
            this.lb_dui.Name = "lb_dui";
            this.lb_dui.Size = new System.Drawing.Size(37, 20);
            this.lb_dui.TabIndex = 8;
            this.lb_dui.Text = "DUI:";
            // 
            // lb_cel
            // 
            this.lb_cel.AutoSize = true;
            this.lb_cel.Location = new System.Drawing.Point(237, 153);
            this.lb_cel.Name = "lb_cel";
            this.lb_cel.Size = new System.Drawing.Size(58, 20);
            this.lb_cel.TabIndex = 9;
            this.lb_cel.Text = "Celular:";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.Location = new System.Drawing.Point(88, 272);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(173, 46);
            this.btn_nuevo.TabIndex = 7;
            this.btn_nuevo.Text = "Nuevo Empleado";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1141, 611);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_planilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_registro";
            this.Text = "Registro de empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_planilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_isss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_renta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_planilla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_cel;
        private System.Windows.Forms.Label lb_dui;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.TextBox txt_dui;
        private System.Windows.Forms.DateTimePicker dtp_nac;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lb_nac;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nud_renta;
        private System.Windows.Forms.NumericUpDown nud_isss;
        private System.Windows.Forms.DateTimePicker dtp_contrato;
        private System.Windows.Forms.TextBox txt_sueldoi;
        private System.Windows.Forms.Label lb_renta;
        private System.Windows.Forms.Label lb_isss;
        private System.Windows.Forms.Label lb_sueldo;
        private System.Windows.Forms.Label lb_contrato;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

