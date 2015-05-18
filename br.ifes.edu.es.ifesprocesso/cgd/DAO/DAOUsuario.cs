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
    public class DAOUsuario: conection
    {
        StringBuilder sb = new StringBuilder();
        public void salvarConteudo(Usuario user)
        {
            sb.Append("");
            try
            {
                this.AbrirConexao();
                sb.Append("Insert into user");
                sb.Append(" (nome, senha) ");
                sb.Append("Values(" + user.funcNome + "," + user.funcSenha + ");");
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
        public void atualizarConteudo(Usuario user)
        {
            sb.Append("");
            try
            {
                this.AbrirConexao();

                sb.Append("UPDATE user SET senha = '" + user.funcSenha + "' WHERE nome = '" + user.funcNome + "';");
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

        public List<Usuario> selecionarConteudo()
        {
            List<Usuario> usuarios = new List<Usuario>();
            sb.Append("");
            try
            {
                this.AbrirConexao();
                sb.Append("SELECT * FROM user");
                MySqlCommand comand = new MySqlCommand(sb.ToString(), Conn);
                MySqlDataReader dtreader = comand.ExecuteReader();
                sb.Clear();

                Usuario leUser = new Usuario();
                while (dtreader.Read())//Enquanto existir dados no select
                {
                    leUser.funcNome = dtreader["nome"].ToString();
                    leUser.funcSenha = dtreader["senha"].ToString();

                    usuarios.Add(leUser);
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
            return usuarios;
        }
    }
}