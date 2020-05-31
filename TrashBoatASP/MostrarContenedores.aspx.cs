using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrashBoatASP.DAL;

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
                this.gvContenedores.DataSource = contenedores.GetContenedorInteligentes();
                this.gvContenedores.DataBind();

            }

        }
    }
}