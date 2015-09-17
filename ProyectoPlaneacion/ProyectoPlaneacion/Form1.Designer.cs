namespace ProyectoPlaneacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOtroF = new System.Windows.Forms.TextBox();
            this.lstRecursos = new System.Windows.Forms.ListBox();
            this.btnMasR = new System.Windows.Forms.Button();
            this.btnMenosR = new System.Windows.Forms.Button();
            this.btnMenosB = new System.Windows.Forms.Button();
            this.btnMasB = new System.Windows.Forms.Button();
            this.lstBeneficios = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMenosF = new System.Windows.Forms.Button();
            this.btnMasF = new System.Windows.Forms.Button();
            this.lstFuentes = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtOtroA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denominacion del Proyecto";
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(171, 18);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(440, 20);
            this.txtDenominacion.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.Enabled = false;
            this.txt.Location = new System.Drawing.Point(171, 57);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(78, 20);
            this.txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Orden de Ejecucion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Funcionario Solicitante";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Items.AddRange(new object[] {
            "Gerente General",
            "Gerente de Recursos Humano",
            "Gerente de Finanzas",
            "Gerente de Ventas",
            "Gerente de Mercadeo",
            "Gerente de Administracion",
            "Gerente Operacional",
            "Gerente de IT",
            "Otro"});
            this.cmbFuncionario.Location = new System.Drawing.Point(171, 88);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(228, 21);
            this.cmbFuncionario.TabIndex = 5;
            this.cmbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cmbFuncionario_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Areas Afectadas";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Items.AddRange(new object[] {
            "Administracion",
            "Finanzas",
            "Operaciones",
            "Sistemas",
            "Mercadeo",
            "Ventas",
            "Recursos Humanos",
            "Otra"});
            this.cmbArea.Location = new System.Drawing.Point(171, 124);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(228, 21);
            this.cmbArea.TabIndex = 8;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripcion del Proyecto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de Inicio";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(171, 231);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de Finalizacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Identificacion de Recursos";
            // 
            // txtOtroF
            // 
            this.txtOtroF.Enabled = false;
            this.txtOtroF.Location = new System.Drawing.Point(407, 88);
            this.txtOtroF.Name = "txtOtroF";
            this.txtOtroF.Size = new System.Drawing.Size(204, 20);
            this.txtOtroF.TabIndex = 16;
            // 
            // lstRecursos
            // 
            this.lstRecursos.FormattingEnabled = true;
            this.lstRecursos.Location = new System.Drawing.Point(172, 263);
            this.lstRecursos.Name = "lstRecursos";
            this.lstRecursos.Size = new System.Drawing.Size(468, 95);
            this.lstRecursos.TabIndex = 17;
            // 
            // btnMasR
            // 
            this.btnMasR.Location = new System.Drawing.Point(646, 279);
            this.btnMasR.Name = "btnMasR";
            this.btnMasR.Size = new System.Drawing.Size(33, 23);
            this.btnMasR.TabIndex = 18;
            this.btnMasR.Text = "+";
            this.btnMasR.UseVisualStyleBackColor = true;
            this.btnMasR.Click += new System.EventHandler(this.btnMasR_Click);
            // 
            // btnMenosR
            // 
            this.btnMenosR.Location = new System.Drawing.Point(646, 308);
            this.btnMenosR.Name = "btnMenosR";
            this.btnMenosR.Size = new System.Drawing.Size(33, 23);
            this.btnMenosR.TabIndex = 19;
            this.btnMenosR.Text = "-";
            this.btnMenosR.UseVisualStyleBackColor = true;
            this.btnMenosR.Click += new System.EventHandler(this.btnMenosR_Click);
            // 
            // btnMenosB
            // 
            this.btnMenosB.Location = new System.Drawing.Point(647, 412);
            this.btnMenosB.Name = "btnMenosB";
            this.btnMenosB.Size = new System.Drawing.Size(33, 23);
            this.btnMenosB.TabIndex = 23;
            this.btnMenosB.Text = "-";
            this.btnMenosB.UseVisualStyleBackColor = true;
            this.btnMenosB.Click += new System.EventHandler(this.btnMenosB_Click);
            // 
            // btnMasB
            // 
            this.btnMasB.Location = new System.Drawing.Point(647, 383);
            this.btnMasB.Name = "btnMasB";
            this.btnMasB.Size = new System.Drawing.Size(33, 23);
            this.btnMasB.TabIndex = 22;
            this.btnMasB.Text = "+";
            this.btnMasB.UseVisualStyleBackColor = true;
            this.btnMasB.Click += new System.EventHandler(this.btnMasB_Click);
            // 
            // lstBeneficios
            // 
            this.lstBeneficios.FormattingEnabled = true;
            this.lstBeneficios.Location = new System.Drawing.Point(173, 367);
            this.lstBeneficios.Name = "lstBeneficios";
            this.lstBeneficios.Size = new System.Drawing.Size(468, 95);
            this.lstBeneficios.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Beneficios Obtenidos";
            // 
            // btnMenosF
            // 
            this.btnMenosF.Location = new System.Drawing.Point(647, 521);
            this.btnMenosF.Name = "btnMenosF";
            this.btnMenosF.Size = new System.Drawing.Size(33, 23);
            this.btnMenosF.TabIndex = 27;
            this.btnMenosF.Text = "-";
            this.btnMenosF.UseVisualStyleBackColor = true;
            this.btnMenosF.Click += new System.EventHandler(this.btnMenosF_Click);
            // 
            // btnMasF
            // 
            this.btnMasF.Location = new System.Drawing.Point(647, 492);
            this.btnMasF.Name = "btnMasF";
            this.btnMasF.Size = new System.Drawing.Size(33, 23);
            this.btnMasF.TabIndex = 26;
            this.btnMasF.Text = "+";
            this.btnMasF.UseVisualStyleBackColor = true;
            this.btnMasF.Click += new System.EventHandler(this.btnMasF_Click);
            // 
            // lstFuentes
            // 
            this.lstFuentes.FormattingEnabled = true;
            this.lstFuentes.Location = new System.Drawing.Point(173, 476);
            this.lstFuentes.Name = "lstFuentes";
            this.lstFuentes.Size = new System.Drawing.Size(468, 95);
            this.lstFuentes.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(28, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 39);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fuente de Obtencion de Recurcos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(516, 587);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 29);
            this.btnAceptar.TabIndex = 28;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(605, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 29);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtOtroA
            // 
            this.txtOtroA.Enabled = false;
            this.txtOtroA.Location = new System.Drawing.Point(407, 124);
            this.txtOtroA.Name = "txtOtroA";
            this.txtOtroA.Size = new System.Drawing.Size(204, 20);
            this.txtOtroA.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 628);
            this.Controls.Add(this.txtOtroA);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnMenosF);
            this.Controls.Add(this.btnMasF);
            this.Controls.Add(this.lstFuentes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMenosB);
            this.Controls.Add(this.btnMasB);
            this.Controls.Add(this.lstBeneficios);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnMenosR);
            this.Controls.Add(this.btnMasR);
            this.Controls.Add(this.lstRecursos);
            this.Controls.Add(this.txtOtroF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan Maestro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOtroF;
        private System.Windows.Forms.ListBox lstRecursos;
        private System.Windows.Forms.Button btnMasR;
        private System.Windows.Forms.Button btnMenosR;
        private System.Windows.Forms.Button btnMenosB;
        private System.Windows.Forms.Button btnMasB;
        private System.Windows.Forms.ListBox lstBeneficios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMenosF;
        private System.Windows.Forms.Button btnMasF;
        private System.Windows.Forms.ListBox lstFuentes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtOtroA;
    }
}

