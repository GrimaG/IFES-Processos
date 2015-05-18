using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace br.ifes.edu.es.ifesprocesso.cgd
{
    public class conection
    {
        protected static MySqlConnection Conn;
        private static MySqlDataAdapter Cmd;
        protected DataSet Dr;
    
        //Abri conexao do banco 
        protected void   AbrirConexao()
        {
            Conn = new MySqlConnection(@"server=us-cdbr-azure-northcentral-a.cleardb.com; user id=b42a467992a0a4; password=2dcf8c7b; database=banco_trabalho");
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            
        }

        //Fecha conexao do banco.
        protected void  FecharConexao()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }



    }


}