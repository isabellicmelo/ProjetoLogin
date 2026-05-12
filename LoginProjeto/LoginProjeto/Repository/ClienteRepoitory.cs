using LoginProjeto.Models;
using LoginProjeto.Repository.Contract;

namespace LoginProjeto.Repository
{
    public class ClienteRepoitory : IClienteRepository
    {
        private readonly string _conexaoMySQL;

        public void Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }

        public Cliente Login(string Email, string Senha)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterCliente(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ObterTodosCliente()
        {
            throw new NotImplementedException();
        }
    }
}
