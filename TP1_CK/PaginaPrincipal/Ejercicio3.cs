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
    }
}
