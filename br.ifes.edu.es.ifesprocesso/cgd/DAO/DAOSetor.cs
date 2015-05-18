using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using br.ifes.edu.es.ifesprocesso.cdp;
using MySql.Data.MySqlClient;
using System.Data;

namespace br.ifes.edu.es.ifesprocesso.cgd.DAO
{
    public class DAOSetor: conection
    {
        StringBuilder sb = new StringBuilder();
        public void salvarConteudo(Setor setor)
        {
            sb.Append("");
            try
            {
                this.AbrirConexao();
                sb.Append("Insert into setor");
                sb.Append(" (setor, nome) ");
                sb.Append("Values(" + setor.funcNome + "," + setor.funcNomeResponsavel + ");");
                MySqlCommand comand = new MySqlCommand(sb.ToString(), Conn);
                comand.BeginExecuteNonQuery();
                sb.Clear();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }
            finally
            {
                this.FecharConexao();
            }
        }
        public void atualizarConteudo(Setor setor)
        {
            sb.Append("");
            try
            {
                this.AbrirConexao();

                sb.Append("UPDATE setor SET nome = '" + setor.funcNomeResponsavel + "' WHERE nome = '" + setor.funcNome + "';");
                MySqlCommand comand = new MySqlCommand(sb.ToString(), Conn);
                comand.BeginExecuteNonQuery();
                sb.Clear();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public List<Setor> selecionarConteudo()
        {
            List<Setor> setores = new List<Setor>();
            sb.Append("");
            try
            {
                this.AbrirConexao();
                sb.Append("SELECT * FROM setor");
                MySqlCommand comand = new MySqlCommand(sb.ToString(), Conn);
                MySqlDataReader dtreader = comand.ExecuteReader();
                sb.Clear();

                Setor leSetor = new Setor();
                while (dtreader.Read())//Enquanto existir dados no select
                {
                    leSetor.funcNome = dtreader["setor"].ToString();
                    leSetor.funcNomeResponsavel = dtreader["nome"].ToString();
                    
                    setores.Add(leSetor);
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }
            finally
            {
                this.FecharConexao();

            }
            return setores;
        }
    }
}