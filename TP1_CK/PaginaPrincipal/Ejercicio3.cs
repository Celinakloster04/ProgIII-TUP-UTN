using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginaPrincipal
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            clbProfesion.Items.Add("Data Entry");
            clbProfesion.Items.Add("Operador de PC");
            clbProfesion.Items.Add("Programador");
            clbProfesion.Items.Add("Reparador de PC");
            clbProfesion.Items.Add("Tester");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string seleccionado = "Usted seleccionó los siguientes elementos: ";
            if(clbProfesion.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleccione algun item", "Error");
                return;
            }
            else
            {
                if (rbFemenino.Checked)
                {
                    if (rbCasado.Checked)
                    {
                        lblMostrar.Text = seleccionado + '\n' + "Sexo: " + rbFemenino.Text + '\n' + "Estado Civil: " + rbCasado.Text + '\n' + "Oficio: " + '\n';
                        foreach (object selected in clbProfesion.CheckedItems)
                        {
                            lblMostrar.Text += "  -" + selected.ToString() + '\n';
                        }
                    }
                    else
                    {
                        lblMostrar.Text = seleccionado + '\n' + "Sexo: " + rbFemenino.Text + '\n' + "Estado Civil: " + rbSoltero.Text + '\n' + "Oficio: " + '\n';
                        foreach (object selected in clbProfesion.CheckedItems)
                        {
                            lblMostrar.Text += "  -" + selected.ToString() + '\n';
                        }
                    }
                }
                else
                {
                    if (rbCasado.Checked)
                    {
                        lblMostrar.Text = seleccionado + '\n' + "Sexo: " + rbMasculino.Text + '\n' + "Estado Civil: " + rbCasado.Text + '\n' + "Oficio: " + '\n';
                        foreach (object selected in clbProfesion.CheckedItems)
                        {
                            lblMostrar.Text += "  -" + selected.ToString() + '\n';
                        }
                    }
                    else
                    {
                        lblMostrar.Text = seleccionado + '\n' + "Sexo: " + rbMasculino.Text + '\n' + "Estado Civil: " + rbSoltero.Text + '\n' + "Oficio: " + '\n';
                        foreach (object selected in clbProfesion.CheckedItems)
                        {
                            lblMostrar.Text += "  -" + selected.ToString() + '\n';
                        }
                    }
                }
            }
        }
    }
}
