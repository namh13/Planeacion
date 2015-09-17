namespace ProyectoPlaneacion
{
    partial class frmBeneficios
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
            this.cmbBeneficio = new System.Windows.Forms.ComboBox();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beneficios";
            // 
            // cmbBeneficio
            // 
            this.cmbBeneficio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeneficio.FormattingEnabled = true;
            this.cmbBeneficio.Items.AddRange(new object[] {
            "Captacion de Clientes",
            "Automatizar Procesos",
            "Satifaccion del Cliente",
            "Otro"});
            this.cmbBeneficio.Location = new System.Drawing.Point(93, 27);
            this.cmbBeneficio.Name = "cmbBeneficio";
            this.cmbBeneficio.Size = new System.Drawing.Size(286, 21);
            this.cmbBeneficio.TabIndex = 1;
            this.cmbBeneficio.SelectedIndexChanged += new System.EventHandler(this.cmbBeneficio_SelectedIndexChanged);
            // 
            // txtOtro
            // 
            this.txtOtro.Enabled = false;
            this.txtOtro.Location = new System.Drawing.Point(93, 56);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(286, 20);
            this.txtOtro.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(395, 30);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 36);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmBeneficios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 84);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtOtro);
            this.Controls.Add(this.cmbBeneficio);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBeneficios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficios Obtenidos";
            this.Load += new System.EventHandler(this.frmBeneficios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBeneficio;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.Button btnAceptar;
    }
}