using LoginProjeto.Models;

namespace LoginProjeto.Repository.Contract
{
    public interface IClienteRepository
    {
        // Login cliente
        Cliente Login(string Email, string Senha);

        //CRUD
        void Cadastrar (Cliente cliente);
        void Atualizar (Cliente cliente);
        void Excluir(int Id);
        Cliente ObterCliente(int Id);
        IEnumerable<Cliente> ObterTodosCliente();
    }
}
