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
    public partial class frmRecursos : Form
    {
        public string p_recursos = "";
        public int p_contador = 0;
        public frmRecursos()
        {
            InitializeComponent();
        }

        private void frmRecursos_Load(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtRecurso.Text != "")
            {
                p_recursos = txtRecurso.Text;
                p_contador = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("El Recurso esta Vacio");
            }
        }

    }
}
