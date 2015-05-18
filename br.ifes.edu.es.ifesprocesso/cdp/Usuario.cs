using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace br.ifes.edu.es.ifesprocesso.cdp
{
    public class Usuario
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
        private String senha;

        public String funcSenha
        {
            get { return senha; }
            set { senha = value; }
        }
        Setor setor;



        public static Usuario verificaUsuario(String nome , String senha) 
        {
            List<Usuario> usuarios = new List<Usuario>();//pegar todos os usuarios do banco

            foreach (var item in usuarios)
            {
                if (item.funcNome.Equals(nome) || item.funcSenha.Equals(senha)) 
                {
                    return item;                
                }
            }


            return null;

            

        }

    }
}