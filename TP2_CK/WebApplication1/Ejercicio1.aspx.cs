using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string tabla = "<table border= '1'>";
            float total = float.Parse(txtCant1.Text) + float.Parse(txtCant2.Text);
            
            tabla += "<tr><th>Producto</th><th>Cantidad</th></tr>";
            tabla += "<tr><td>" + txtProd1.Text + "</td><td>" + txtCant1.Text + "</td></tr>";
            tabla += "<tr><td>" + txtProd2.Text + "</td><td>" + txtCant2.Text + "</td></tr>";
            tabla += "<tr><th>TOTAL</th><td>" + total + "</td></tr>";

            lblTabla.Text = tabla;
        }
    }
}