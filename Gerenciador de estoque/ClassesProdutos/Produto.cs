using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Gerenciador_de_estoque
{
    public class Produto
    {
        private String nome;
        public String Nome
        {
            get {return nome;}
            set
            {
                if (value.Length > 32)
                    throw new Exception("Tamanho inválido");
                else
                nome = value;
            }
            
        }

        public int Id { get; set; }
        public int? Quantidade { get; set; }
        public double? Preco { get; set; }
        public double? PrecoDeVenda { get; set; }
        public Categoria Categoria { get; set; }
        public String Descricao { get; set; }
        public bool Status { get; set; }     //Atributo que define se o produto está ativo ou não
        public DateTime? Venda { get; set; } //Atributo que define a data da Ultima venda
        public DateTime UltimaAlteracao { get; set; }  // Atributo que define a ultima atualização do produto (Alteração, venda)

        public Produto(string nome, int id, int? quantidade, double? preco, double? precoDeVenda, Categoria categoria, string descricao, bool status)
        {
            Nome = nome;
            Id = id;
            Quantidade = quantidade;
            Preco = preco;
            PrecoDeVenda = precoDeVenda;
            Categoria = categoria;
            Descricao = descricao;
            Status = status;

            // Inicializa a data da última alteração com a data e hora atuais
            UltimaAlteracao = DateTime.Now;

            // A data da última venda pode ser inicializada como nula, pois não houve venda ainda
            Venda = null;
        }

        public void RegistrarVenda(int quantidadeVendida)
        {
            if (Quantidade.HasValue && Quantidade >= quantidadeVendida)
            {
                Quantidade -= quantidadeVendida;
                Venda = DateTime.Now;
                UltimaAlteracao = DateTime.Now;
            }
            else
            {
                // Tratar o caso em que a quantidade disponível é insuficiente
            }
        }

        public void AtualizarProduto(int novaQuantidade, double novoPreco)
        {
            // Atualize os campos relevantes
            Quantidade = novaQuantidade;
            Preco = novoPreco;

            // Atualize a data da última alteração
            UltimaAlteracao = DateTime.Now;
        }

        public void AtualizarPreco(double novoPreco)
        {
            if (novoPreco >= 0)
            {
                Preco = novoPreco;
                UltimaAlteracao = DateTime.Now;
            }
            else
            {
                // Trate o caso em que o preço é negativo
            }
        }

        public void AtualizarPrecoDeVenda(double novoPreco)
        {
            if (novoPreco >= 0)
            {
                PrecoDeVenda = novoPreco;
                UltimaAlteracao = DateTime.Now;
            }
            else
            {
                // Trate o caso em que o preço é negativo
            }
        }

        public double CalcularValorTotalDeVenda()  //Preço imbuido de lucro
        {
            if (Quantidade.HasValue && PrecoDeVenda.HasValue)
            {
                return Quantidade.Value * PrecoDeVenda.Value;
            }
            else
            {
                // Trate o caso em que a quantidade ou o preço é nulo
                return 0.0;
            }
        }

        public double CalcularValorTotal()      //Sem Lucro
        {
            if (Quantidade.HasValue && Preco.HasValue)
            {
                return Quantidade.Value * Preco.Value;
            }
            else
            {
                // Trate o caso em que a quantidade ou o preço é nulo
                return 0.0;
            }
        }

        public void AtualizarQuantidade(int novaQuantidade)
        {
            if (novaQuantidade >= 0)
            {
                Quantidade = novaQuantidade;
                UltimaAlteracao = DateTime.Now;
            }
            else
            {
                throw new Exception("Não é possível atualizar a quantidade para um valor negativo!");
            }
        }

        public bool Equals(Produto outroProduto)
        {
            return Id == outroProduto.Id;
        }

        /// <summary> CalcularValorTotal()-CalcularValorTotalDeVenda() = LUCRO </summary>
    }
}