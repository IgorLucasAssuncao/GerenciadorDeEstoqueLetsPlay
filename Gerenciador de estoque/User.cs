namespace Gerenciador_de_estoque
{
    internal class User
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        public User(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public bool Autenticar(string nome, string senha)
        {
            return (nome == Nome && senha == Senha);
        }
    }
}