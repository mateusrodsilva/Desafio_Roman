using senai.roman.webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.roman.webapi.Interfaces
{
    interface IProjetoRepository
    {
        /// <summary>
        /// Método que cadastra uma novo Projeto
        /// </summary>
        /// <param name="NovoProjeto">Projeto que será Cadastrado</param>
        public void Cadastrar(Projeto NovoProjeto);

        /// <summary>
        /// Lista todos os Projetos
        /// </summary>
        /// <returns>Lista com os Projetos</returns>
        List<Projeto> Listar();

        /// <summary>
        /// Busca um Projeto pelo id 
        /// </summary>
        /// <param name="id">id do Projeto que será buscado</param>
        /// <returns>Projeto Buscado</returns>
        Projeto BuscarPorId(int id);

        /// <summary>
        /// Atualiza um Projeto pelo Id
        /// </summary>
        /// <param name="id">Id do Projeto que será atualizado</param>
        /// <param name="ProjetoAtt">Objeto ProjetoAtt com as informações atualizadas</param>
        void Atualizar(int id, Projeto ProjetoAtt);

        /// <summary>
        /// Deleta um Projeto existente
        /// </summary>
        /// <param name="id">Id do Projetoo que será deletado</param>
        void Deletar(int id);
    }
}
