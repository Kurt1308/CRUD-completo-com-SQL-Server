using Microsoft.AspNetCore.Mvc;
using ProjetoPraticoPDI.Model;
using ProjetoPraticoPDI.Interfaces;

namespace ProjetoPraticoPDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjetoPraticoPDIController : ControllerBase 
    {
        public readonly IPessoaRepository _pessoaRepository;

        public ProjetoPraticoPDIController()
        {
            _pessoaRepository = new Repository.PessoaRepository();
        }
        [HttpGet]
        [Route("GetPessoas")]
        public ActionResult<IEnumerable<Pessoa>> GetPessoas()
        {
            return _pessoaRepository.GetPessoas();
        }
        [HttpGet]
        [Route("GetPessoaById")]
        public ActionResult<IEnumerable<Pessoa>> GetPessoaById(int id)
        {
            return _pessoaRepository.GetPessoaById(id);  
        }

        [HttpPost]
        [Route("InserirPessoa")]
        public void PostPessoa([FromBody] PessoaDTO pessoaDTO)
        {
            _pessoaRepository.InserirPessoa(pessoaDTO);
        }
        [HttpPut]
        [Route("UpdatePessoa")]
        public void PutPessoa([FromBody] Pessoa pessoa)
        {
            _pessoaRepository.UpdatePessoa(pessoa);
        }
        [HttpDelete]
        [Route("DeletePessoa")]
        public void DeletePessoa(int id)
        {
            _pessoaRepository.DeletePessoa(id);
        }
    }
}