using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrashBoatASP.DAL;
using TrashBoatASP.DTO;

namespace TrashBoatASP
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("funciona1");
        }

     

        protected void btnIngresarContenedor_Click(object sender, EventArgs e)
        {
            ContenedorInteligente contenedor = new ContenedorInteligente();
            long idContenedor = Int64.Parse(txtIdContenedor.Text);
            string nombreClave  = txtNombreClave.Text;
            double capacidadTotal =(double)Convert.ToDecimal(txtCapacidadTotal.Text);
            double capacidadActual = (double)Convert.ToDecimal(ddlCapacidadActual.Text);
            capacidadActual = (capacidadActual * capacidadTotal);

            contenedor.IdContenedor = idContenedor;
            contenedor.NombreClave = nombreClave;
            contenedor.CapacidadActual = capacidadActual;
            contenedor.CapacidadTotal = capacidadTotal;

            ContenedorDAL contenedores = new StaticContenedorDAL();
            contenedores.agregarContenedores(contenedor);

            Response.Redirect("MostrarContenedores.aspx");
            
            

        }

    }
}