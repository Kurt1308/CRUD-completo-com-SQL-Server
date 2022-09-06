using ProjetoPraticoPDI.Model;

namespace ProjetoPraticoPDI.Interfaces
{
    public interface IPessoaRepository
    {
        public List<Pessoa> GetPessoaById(int id);
        public void InserirPessoa(PessoaDTO pessoaDTO);
        public void DeletePessoa(int id);
        public void UpdatePessoa(Pessoa pessoa);
        public List<Pessoa> GetPessoas();
    }
}
