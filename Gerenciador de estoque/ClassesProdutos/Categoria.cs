using System;

namespace Gerenciador_de_estoque
{
    public class Categoria
    {
        public String Nome
        {
            get { return Nome; }
            set
            {
                if (value.Length > 32)
                    throw new Exception("Tamanho inválido");
            }
        }

        public String Descricao
        {
            get { return Nome; }
            set
            {
                if (value.Length > 200)
                    throw new Exception("Tamanho inválido");
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