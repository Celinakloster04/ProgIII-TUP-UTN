using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginaPrincipal
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        { 
            bool seRepite = false;  

            if(tbxNombre.Text.Trim() == "")
            {
                MessageBox.Show("No se admiten nombres vacíos!", "Advertencia");
            }
            
            foreach (String p in lbIzq.Items)
            {
                if (tbxNombre.Text.Trim().ToUpper() == p.Trim().ToUpper())
                {   
                    MessageBox.Show("Ya existe ese nombre", "Error");
                    seRepite = true;
                } 


            }

            if (seRepite)
            {
                tbxNombre.Text = "";
            }
            else
            {
                lbIzq.Items.Add(tbxNombre.Text);
                tbxNombre.Text = "";
            }
  
        }

        private void btnPasarUnItem_Click(object sender, EventArgs e)
        {
            if (lbIzq.SelectedItem == null)
            {
                MessageBox.Show("Debe Seleccionar un ítem");
                return;

            }
            else
            {
                lbDer.Items.Add(lbIzq.SelectedItem);
                lbIzq.Items.Remove(lbIzq.SelectedIndex);
            }

            foreach(String p in lbDer.Items)
            {
                if(p.ToString().Trim().ToUpper() == lbIzq.SelectedItem.ToString().Trim().ToUpper())
                {
                    lbIzq.Items.Remove(p);
                }
            }
        }

        private void btnPasarItems_Click(object sender, EventArgs e)
        {
            bool cambiados = false;

            if (lbIzq.Items.Count > 0)
            {
                foreach (String p in lbIzq.Items)
                {
                    lbDer.Items.Add(p);
                    cambiados = true;
                }
                if (cambiados == true)
                {
                    lbIzq.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("No hay elementos en la lista");
            }
        }
    }
}
