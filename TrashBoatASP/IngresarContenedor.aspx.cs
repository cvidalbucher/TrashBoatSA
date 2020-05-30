using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrashBoatASP.DTO;

namespace TrashBoatASP
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     

        protected void btnIngresarContenedor_Click(object sender, EventArgs e)
        {
            ContenedorInteligente contenedor = new ContenedorInteligente();
            string idContenedor = txtIdContenedor.Text;
            string ubicacion = txtUbicacion.Text;
            string nivelLlenado = txtNivelLlenado.Text;
            string ultimaDescarga = txtUltimaDescarga.Text;

        }
    }
}