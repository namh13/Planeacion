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
    public partial class Form1 : Form
    {
        int contadorF = 0;
        int contadorR = 0;
        int contadorB = 0;
        int contadorFuncionario = 0;
        int contadorAreas = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void AgregarRecurso()
        {
            frmRecursos frm = new frmRecursos();
            frm.ShowDialog(this);
            if (frm.p_recursos != "")
            {
                lstRecursos.Items.Add(frm.p_recursos);
            }
            contadorR += frm.p_contador;
        }

        private void btnMasR_Click(object sender, EventArgs e)
        {
            AgregarRecurso();
        }

        private void AgregarBeneficio()
        {
            frmBeneficios frm = new frmBeneficios();
            frm.ShowDialog(this);

            if(frm.p_beneficios != "")
            {
                lstBeneficios.Items.Add(frm.p_beneficios);
            }
            contadorB += frm.p_contador;
            MessageBox.Show(contadorB.ToString());
        }

        private void btnMasB_Click(object sender, EventArgs e)
        {
            AgregarBeneficio();
        }

        private void AgregarFuente()
        {
            frmFuente frm = new frmFuente();
            frm.ShowDialog(this);

            if(frm.p_fuente != "")
            {
                lstFuentes.Items.Add(frm.p_fuente);
            }
            contadorF += frm.p_contador;
        }

        private void btnMasF_Click(object sender, EventArgs e)
        {
            AgregarFuente();
        }

        private void btnMenosR_Click(object sender, EventArgs e)
        {
            if(lstRecursos.SelectedIndex >= 0)
            {
                lstRecursos.Items.RemoveAt(lstRecursos.SelectedIndex);
                contadorR -= 1;
            }
        }

        private void btnMenosB_Click(object sender, EventArgs e)
        {
            if(lstBeneficios.SelectedIndex >= 0)
            {
                EliminarBeneficio(lstBeneficios.SelectedIndex);
                MessageBox.Show(contadorB.ToString());
            }
        }

        private void btnMenosF_Click(object sender, EventArgs e)
        {
            if(lstFuentes.SelectedIndex >= 0)
            {
                lstFuentes.Items.RemoveAt(lstFuentes.SelectedIndex);
                contadorF -= 1;
            }
        }

        private void EliminarBeneficio(int borrar)
        {
                string beneficio1 = "Captacion de Clientes";
                string beneficio2 = "Automatizar Procesos";
                string beneficio3 = "Satifaccion del Cliente";
                int a = lstBeneficios.FindString(beneficio1);
                int b = lstBeneficios.FindString(beneficio2);
                int c = lstBeneficios.FindString(beneficio3);

                if(borrar == a)
                {
                    lstBeneficios.Items.RemoveAt(a);
                    contadorB -= 2;
                }
                if (borrar == b)
                {
                    lstBeneficios.Items.RemoveAt(b);
                    contadorB -= 2;
                }
                if (borrar == c)
                {
                    lstBeneficios.Items.RemoveAt(c);
                    contadorB -= 2;
                }
                if(borrar != a && borrar != b && borrar != c)
                {
                    lstBeneficios.Items.RemoveAt(borrar);
                    contadorB -= 1;
                }
        }

        private void cmbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            contadorFuncionario = 0;
            if (cmbFuncionario.SelectedIndex.Equals(8))
            {
                txtOtroF.Enabled = true;
            }
            else
            {
                txtOtroF.Enabled = false;
            }
            ContadorFuncionarioSolicitante();
            MessageBox.Show(contadorFuncionario.ToString());
        }

        private void ContadorFuncionarioSolicitante()
        {
            string funcionario = cmbFuncionario.SelectedItem.ToString();
            if(funcionario == "Gerente General")
            {
                contadorFuncionario += 3;
            }
            if(funcionario == "Otro")
            {
                contadorFuncionario += 1;
            }
            if(funcionario != "Gerente General" && funcionario != "Otro")
            {
                contadorFuncionario += 2;
            }
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            contadorAreas = 0;
            if (cmbArea.SelectedIndex.Equals(7))
            {
                txtOtroA.Enabled = true;
            }
            else
            {
                txtOtroA.Enabled = false;
            }
            ContadorAreas();
            MessageBox.Show(contadorAreas.ToString());
        }

        private void ContadorAreas()
        {
            string area = cmbArea.SelectedItem.ToString();
            if (area == "Administracion" || area == "Ventas")
            {
                contadorAreas += 3;
            }
            if (area == "Otra")
            {
                contadorAreas += 1;
            }
            if (area != "Administracion" && area != "Ventas" && area != "Otra")
            {
                contadorAreas += 2;
            }
        }

    }
}
