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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string apellido = txbApellido.Text;
            string nYa = nombre + " " + apellido;

            if (lbNombres.Items.Count > 0) 
            {
                foreach (string persona in lbNombres.Items)
                {
                    if (nYa.ToString().ToUpper() == persona.ToString().ToUpper())
                    {
                        MessageBox.Show("No se permiten nombres repetidos", "Error");
                        txbNombre.Text = "";
                        txbApellido.Text = "";
                        return;
                    }
                }
            }

            if (nombre == "" || apellido == "")
            {
                txbNombre.Text = "";
                txbApellido.Text = "";
                MessageBox.Show("Debe completar ambos campos", "Error");
                return;
            }
            else if (!GlobalFunctions.EsNombreValido(nombre) || !GlobalFunctions.EsNombreValido(apellido))
            {
                MessageBox.Show("Datos inválidos", "Error");
                txbNombre.Text = "";
                txbApellido.Text = "";
                return;
                
            }
            else
            {
                lbNombres.Items.Add(nombre + " " + apellido);
                txbNombre.Text = "";
                txbApellido.Text = "";
            }

            GlobalFunctions.OrdenarAlfabeticamente(lbNombres);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(lbNombres.SelectedIndex != -1)
            {
                lbNombres.Items.RemoveAt(lbNombres.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item", "Error");
            }
            
        }
    }
}
