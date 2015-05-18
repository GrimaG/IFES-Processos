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
    public class DAOProcesso: conection
    {
        StringBuilder sb = new StringBuilder();
        public void salvarConteudo(Processo process)
        {
            sb.Append("");
            try
            {
                this.AbrirConexao();
                sb.Append("Insert into Processo");
                sb.Append(" (protocolo,descricao,situacao, nome) ");
                sb.Append("Values("+process.funcProtocolo+","+process.funNome_Processo+","+process.funcSituacao+","+process.funNome_Requerente+");");
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
        public void atualizarConteudo(Processo process)
        {
            sb.Append("");
            try
            {
                this.AbrirConexao();

                sb.Append("UPDATE processo SET descricao = '" + process.funNome_Processo + "', situacao = '" + process.funcSituacao + "', nome = '" + process.funNome_Requerente + "' WHERE protocolo = '" + process.funcProtocolo + "';");
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

        public List<Processo> selecionarConteudo()
        {
            List<Processo> processos = new List<Processo>();
            sb.Append("");
            try
            {
                this.AbrirConexao();
                sb.Append("SELECT * FROM processo");
                MySqlCommand comand = new MySqlCommand(sb.ToString(), Conn);
                MySqlDataReader dtreader = comand.ExecuteReader();
                sb.Clear();
                
                Processo leProcesso = new Processo();
                while (dtreader.Read())//Enquanto existir dados no select
                {
                    leProcesso.funcProtocolo = dtreader["protocolo"].ToString();
                    leProcesso.funNome_Processo = dtreader["descricao"].ToString();
                    leProcesso.funcSituacao = dtreader["situacao"].ToString();
                    leProcesso.funNome_Requerente = dtreader["nome"].ToString();
                    processos.Add(leProcesso);
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
            return processos;
        }

    }
}