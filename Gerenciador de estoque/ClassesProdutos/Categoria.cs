using System;

namespace Gerenciador_de_estoque
{
    public class Categoria
    {
        private String nome;
        public String Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 32)
                    throw new Exception("Tamanho inválido");
                else
                    nome = value;
            }
        }

        private String descricao;
        public String Descricao
        {
            get { return descricao; }
            set
            {
                if (value.Length > 200)
                    throw new Exception("Tamanho inválido");
                else
                {
                    descricao = value;
                }
            }
        }
        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
        public Categoria()
        {
            Nome = "";
            Descricao = "";
        }
    }
}