using ProjetoPraticoPDI.Model;
using ProjetoPraticoPDI.Service;
using ProjetoPraticoPDI.Interfaces;

namespace ProjetoPraticoPDI.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly ServicePessoa _ServicePessoa;

        public PessoaRepository()
        {
            _ServicePessoa = new ServicePessoa();
        }
        public List<Pessoa> GetPessoas()
        {
            {
                return _ServicePessoa.GetPessoas();
            }
        }
        public List<Pessoa> GetPessoaById(int id)
        {
            {
                return _ServicePessoa.GetPessoaById(id);
            }
        }
        public void InserirPessoa(PessoaDTO pessoaDTO)
        {
            _ServicePessoa.InserirPessoa(pessoaDTO);
        }
        public void DeletePessoa(int id)
        {
            _ServicePessoa.DeletePessoa(id);
        }
        public void UpdatePessoa(Pessoa pessoa)
        {
            _ServicePessoa.UpdatePessoa(pessoa);
        }
    }
}
