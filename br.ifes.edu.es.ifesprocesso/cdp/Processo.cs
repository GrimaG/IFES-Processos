using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace br.ifes.edu.es.ifesprocesso.cdp
{
    public class Processo
    {
        private int ID;//Id do banco, colocar aqui

        public int funcID
        {
            get { return ID; }
            set { ID = value; }
        }

        private String nomeProcesso;

        public String funNome_Processo
        {
            get { return nomeProcesso; }
            set { nomeProcesso = value; }
        }
        private String nomeRequerente;

        public String funNome_Requerente
        {
            get { return nomeRequerente; }
            set { nomeRequerente = value; }
        }
        private String protocolo;

        public String funcProtocolo
        {
            get { return protocolo; }
            set { protocolo = value; }
        }

        List<Setor> setores;
   }
}