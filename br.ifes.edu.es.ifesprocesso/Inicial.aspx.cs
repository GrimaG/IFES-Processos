using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace br.ifes.edu.es.ifesprocesso
{
    public partial class Inicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String strValorSession = Session["UsuarioID"].ToString();
            btn_Cadastrar.Text = Session["UsuarioID"].ToString();
        }

        protected void ainicial_Click(object sender, EventArgs e)
        {
            
            var url = "~/Inicial.aspx?UsuarioID=" + 1; //usuario.funcID ;
        }

    }
}