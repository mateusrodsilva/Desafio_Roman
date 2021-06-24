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
    public class TemaController : ControllerBase
    {
        private ITemaRepository _temaRepository { get; set; }
        public TemaController()
        {
            _temaRepository = new TemaRepository();
        }

        /// <summary>
        /// Lista todos os Temas 
        /// </summary>
        /// <returns>Lista com os Temas</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_temaRepository.Listar());
        }

        /// <summary>
        /// Método que cadastra um Novo Tema
        /// </summary>
        /// <param name="NovoTema">Novo Tema que será cadastrado</param>
        [Authorize]
        [HttpPost]
        public IActionResult Post(Tema NovoTema)
        {
            _temaRepository.Cadastrar(NovoTema);

            return StatusCode(201);
        }

        /// <summary>
        /// Busca um Tema pelo id
        /// </summary>
        /// <param name="id">id do Tema que será buscado</param>
        /// <returns>Tema Buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_temaRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Deleta um Tema existente
        /// </summary>
        /// <param name="id">Id do Tema que será deletado</param>
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _temaRepository.Deletar(id);

            return StatusCode(204);
        }

        /// <summary>
        /// Atualiza um Tema pelo Id
        /// </summary>
        /// <param name="id">Id do Tema que será atualizado</param>
        /// <param name="TemaAtt">Objeto TemaAtt com as informações atualizadas</param
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Tema TemaAtt)
        {
            // Faz a chamada para o método
            _temaRepository.Atualizar(id, TemaAtt);

            // Retorna um status code
            return StatusCode(204);
        }
    }
}
