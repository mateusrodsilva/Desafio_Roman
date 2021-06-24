using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using senai.roman.webapi.Domains;
using senai.roman.webapi.Interfaces;
using senai.roman.webapi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.roman.webapi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {

        private IProjetoRepository _projetoRepository { get; set; }
        public ProjetoController()
        {
            _projetoRepository = new ProjetoRepository();
        }

        /// <summary>
        /// Lista todos os Projetos
        /// </summary>
        /// <returns>Lista com os Projetos</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_projetoRepository.Listar());
        }

        /// <summary>
        /// Método que cadastra uma novo Projeto
        /// </summary>
        /// <param name="NovoProjeto">Projeto que será Cadastrado</param>
        [Authorize]
        [HttpPost]
        public IActionResult Post(Projeto NovoProjeto)
        {
            _projetoRepository.Cadastrar(NovoProjeto);

            return StatusCode(201);
        }

        /// <summary>
        /// Busca um Projeto pelo id 
        /// </summary>
        /// <param name="id">id do Projeto que será buscado</param>
        /// <returns>Projeto Buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_projetoRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Deleta um Projeto existente
        /// </summary>
        /// <param name="id">Id do Projetoo que será deletado</param>
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _projetoRepository.Deletar(id);

            return StatusCode(204);
        }

        /// <summary>
        /// Atualiza um Projeto pelo Id
        /// </summary>
        /// <param name="id">Id do Projeto que será atualizado</param>
        /// <param name="ProjetoAtt">Objeto ProjetoAtt com as informações atualizadas</param>
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Projeto ProjetoAtt)
        {
            // Faz a chamada para o método
            _projetoRepository.Atualizar(id, ProjetoAtt);

            // Retorna um status code
            return StatusCode(204);
        }
    }
}
