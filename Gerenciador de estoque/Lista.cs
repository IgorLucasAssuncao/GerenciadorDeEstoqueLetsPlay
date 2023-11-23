using System;

namespace Gerenciador_de_estoque
{
    internal class Celula<T> 
    {
        private T item;
        private Celula<T> proximo;
        private Celula<T> anterior;

        public T Item
        {
            get { return item; }
            set { item = value; }
        }

        public Celula<T> Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

        public Celula<T> Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public Celula(T novo)
        {
            item = novo;
            anterior = null;
            proximo = null;
        }

        public Celula()
        {
            item = default(T);
            anterior = null;
            proximo = null;
        }
    }

    internal class Lista<T> 
    {
        private Celula<T> primeiro;
        private Celula<T> ultimo;
        private int tamanho;

        public Lista()
        {
            Celula<T> sentinela;

            sentinela = new Celula<T>();

            primeiro = sentinela;
            ultimo = sentinela;

            tamanho = 0;
        }

        public Boolean listaVazia()
        {
            Boolean resp;

            if (primeiro == ultimo)
                resp = true;
            else
                resp = false;

            return resp;
        }
        public T GetItem(int posicao)
        {
           if (!listaVazia())
            {
                if ((posicao < 0) || (posicao >= tamanho))
                    throw new Exception("Não foi possível obter o item da lista: a posição informada é inválida!");

                Celula<T> atual = primeiro.Proximo;

                for (int i = 0; i < posicao; i++)
                {
                    atual = atual.Proximo;
                }

                return atual.Item;
            }
            else
                throw new Exception("Não foi possível obter o item da lista: a lista está vazia!");
        
        }

        public void Add(T novo)
        {
            Celula<T> novaCelula;

            novaCelula = new Celula<T>(novo);

            ultimo.Proximo = novaCelula;
            novaCelula.Anterior = ultimo;

            ultimo = novaCelula;

            tamanho++;
        }

        public T removerFinal()
        {
            Celula<T> removida, penultima;

            if (!listaVazia())
            {
                removida = ultimo;

                penultima = ultimo.Anterior;
                penultima.Proximo = null;
                removida.Anterior = null;

                ultimo = penultima;

                tamanho--;

                return (removida.Item);
            }
            else
                throw new Exception("Não foi possível remover o último item da lista: a lista está vazia!");
        }

        public void inserir(T novo, int posicao)
        {
            Celula<T> anterior, novaCelula, proximaCelula;

            if ((posicao >= 0) && (posicao <= tamanho))
            {
                anterior = primeiro;
                for (int i = 0; i < posicao; i++)
                    anterior = anterior.Proximo;

                novaCelula = new Celula<T>(novo);

                proximaCelula = anterior.Proximo;

                anterior.Proximo = novaCelula;
                novaCelula.Proximo = proximaCelula;

                if (posicao == tamanho)  // a inserção ocorreu na última posição da lista
                    ultimo = novaCelula;

                tamanho++;
            }
            else
                throw new Exception("Não foi possível inserir o item na lista: a posição informada é inválida!");
        }

        public T remover(int posicao)
        {
            Celula<T> anterior, celulaRemovida, proximaCelula;

            if (!listaVazia())
            {
                if ((posicao >= 0) && (posicao < tamanho))
                {
                    anterior = primeiro;
                    for (int i = 0; i < posicao; i++)
                        anterior = anterior.Proximo;

                    celulaRemovida = anterior.Proximo;

                    proximaCelula = celulaRemovida.Proximo;

                    anterior.Proximo = proximaCelula;
                    celulaRemovida.Proximo = null;

                    if (celulaRemovida == ultimo)
                        ultimo = anterior;

                    tamanho--;

                    return (celulaRemovida.Item);
                }
                else
                    throw new Exception("Não foi possível remover o item da lista: a posição informada é inválida!");
            }
            else
                throw new Exception("Não foi possível remover o item da lista: a lista está vazia!");
        }

        public int contarElemento(T elemento)
        {
            int contador = 0;
            Celula<T> atual = primeiro.Proximo;

            while (atual != null)
            {
                if (atual.Item.Equals(elemento))
                {
                    contador++;
                }
                atual = atual.Proximo;
            }

            return contador;
        }

        public void remover(T elemento)
        {
            Celula<T> anterior = primeiro;
            Celula<T> atual = primeiro.Proximo;

            while (atual != null)
            {
                if (atual.Item.Equals(elemento))
                {
                    Celula<T> proximaCelula = atual.Proximo;
                    anterior.Proximo = proximaCelula;

                    if (atual == ultimo)
                    {
                        ultimo = anterior;
                    }

                    atual.Proximo = null;
                    tamanho--;
                    return; // Elemento encontrado e removido
                }

                anterior = atual;
                atual = atual.Proximo;
            }

            // Elemento não encontrado
            throw new Exception("Não foi possível remover o elemento da lista: elemento não encontrado!");
        }
        public bool Contains(T elemento)
        {    
                Celula<T> atual = primeiro.Proximo;

                while (atual != null)
                {
                    if (atual.Item.Equals(elemento))
                    {
                        return true;
                    }
                    atual = atual.Proximo;
                }

                return false;
        }
    }
}