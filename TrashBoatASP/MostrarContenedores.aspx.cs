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
    public partial class WebForm3 : System.Web.UI.Page
    {
        ContenedorDAL contenedores;
        protected void Page_Load(object sender, EventArgs e)
        {
            contenedores = new StaticContenedorDAL();
            if (!IsPostBack)
            {
                double numero = contenedores.GetContenedorInteligentes().ElementAt<ContenedorInteligente>(0).CapacidadTotal;
                this.gvContenedores.DataSource = contenedores.GetContenedorInteligentes();
                this.gvContenedores.DataBind();
                String.Format("{0:0.00}", numero);
                lblPrueba.Text = Convert.ToString(numero);
                
            }

        }
    }
}