using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace br.ifes.edu.es.ifesprocesso.cdp
{
    public class Setor
    {
        private int ID;//Id do banco, colocar aqui

        public int funcID
        {
            get { return ID; }
            set { ID = value; }
        }
        private String nome;

        public String funcNome
        {
            get { return nome; }
            set { nome = value; }
        }
        private String nomeResponsavel;

        public String funcNomeResponsavel
        {
            get { return nomeResponsavel; }
            set { nomeResponsavel = value; }
        }

        List<Processo> processos;
        List<Processo> dependentes;






    }
}