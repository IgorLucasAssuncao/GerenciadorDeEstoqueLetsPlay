namespace Gerenciador_de_estoque
{
    internal class Estoque
    {
        public Lista<Produto> Produtos { get; set; }

        public Estoque()
        {
            Produtos = new Lista<Produto>();
        }

        /// Adicionar Por arquivo**
        ///
        /// <summary>Funções
        /// Adicionar
        /// Deletar
        /// Alterar
        /// Pesquisar
    }
}