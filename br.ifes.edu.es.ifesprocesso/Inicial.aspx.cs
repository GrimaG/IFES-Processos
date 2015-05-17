using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using br.ifes.edu.es.ifesprocesso.cdp;

namespace br.ifes.edu.es.ifesprocesso
{
    public partial class Inicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String strValorSession = Session["UsuarioID"].ToString();
            Processo processo = new Processo();
            Setor setor = new Setor();


            setor.funcNome = "Cefor";
            setor.funcNomeResponsavel = "Aline";
            processo.funcProtocolo = "CEFOR12";
            processo.funNome_Processo = "Abertura";
            processo.funNome_Requerente = "Albeto";

            processo.setores = new List<Setor>();
            setor.processos = new List<Processo>();
            processo.setores.Add(setor);
            setor.processos.Add(processo);
            gv_MeusProcessos.DataSource = setor.processos;
            gv_MeusProcessos.DataBind();


            gv_processospendentes.DataSource = setor.processos;
            gv_processospendentes.DataBind();




        }

        protected void ainicial_Click(object sender, EventArgs e)
        {

            var url = "~/Inicial.aspx?UsuarioID=" + 1; //usuario.funcID ;
        }


        protected void gv_MeusProcessos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var obj = (Processo)e.Row.DataItem;


                // HyperLink hlkTipolicitacao = (HyperLink)e.Row.FindControl("hlkTipolicitacao");

                Label lblrequerente = (Label)e.Row.FindControl("lblrequerente");

                Label lbldescricao = (Label)e.Row.FindControl("lbldescricao");

                Label lblprotocolo = (Label)e.Row.FindControl("lblprotocolo");


                Label lblSetor = (Label)e.Row.FindControl("lblSetor");


                lbldescricao.Text = obj.funcDescricao;
                lblrequerente.Text = obj.funNome_Requerente;
                lblprotocolo.Text = obj.funcProtocolo;
                var variavel = obj.setores[obj.setores.Count - 1 ];
                lblSetor.Text = variavel.funcNome;

            

            }
        }


        protected void gv_processospendentes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var obj = (Processo)e.Row.DataItem;


                // HyperLink hlkTipolicitacao = (HyperLink)e.Row.FindControl("hlkTipolicitacao");

                Label lblrequerente = (Label)e.Row.FindControl("lblrequerente");

                Label lbldescricao = (Label)e.Row.FindControl("lbldescricao");

                Label lblprotocolo = (Label)e.Row.FindControl("lblprotocolo");


                Label lblSetor = (Label)e.Row.FindControl("lblSetor");


                lbldescricao.Text = obj.funcDescricao;
                lblrequerente.Text = obj.funNome_Requerente;
                lblprotocolo.Text = obj.funcProtocolo;
                var variavel = obj.setores[obj.setores.Count - 1];
                lblSetor.Text = variavel.funcNome;



            }
        }


    }
}

