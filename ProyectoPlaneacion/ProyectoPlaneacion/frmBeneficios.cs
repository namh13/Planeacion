using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlaneacion
{
    public partial class frmBeneficios : Form
    {
        public string p_beneficios = "";
        public int p_contador = 0;
        public frmBeneficios()
        {
            InitializeComponent();
        }

        private void frmBeneficios_Load(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cmbBeneficio.Text != "")
            {
                p_beneficios = cmbBeneficio.SelectedItem.ToString();
                if(p_beneficios == "Otro")
                {
                    p_beneficios = txtOtro.Text;
                    p_contador = 1;
                }
                else
                {
                    p_contador = 2;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("El Beneficio esta Vacio");
            }
        }

        private void cmbBeneficio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBeneficio.SelectedIndex.Equals(3))
            {
                txtOtro.Enabled = true;
            }
            else
            {
                txtOtro.Enabled = false;
            }
        }
    }
}
