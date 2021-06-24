using senai.roman.webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.roman.webapi.Interfaces
{
    interface ITemaRepository
    {
        /// <summary>
        /// Método que cadastra um Novo Tema
        /// </summary>
        /// <param name="NovoTema">Novo Tema que será cadastrado</param>
        public void Cadastrar(Tema NovoTema);

        /// <summary>
        /// Lista todos os Temas 
        /// </summary>
        /// <returns>Lista com os Temas</returns>
        List<Tema> Listar();

        /// <summary>
        /// Busca um Tema pelo id
        /// </summary>
        /// <param name="id">id do Tema que será buscado</param>
        /// <returns>Tema Buscado</returns>
        Tema BuscarPorId(int id);

        /// <summary>
        /// Atualiza um Tema pelo Id
        /// </summary>
        /// <param name="id">Id do Tema que será atualizado</param>
        /// <param name="TemaAtt">Objeto TemaAtt com as informações atualizadas</param>
        void Atualizar(int id, Tema TemaAtt);

        /// <summary>
        /// Deleta um Tema existente
        /// </summary>
        /// <param name="id">Id do Tema que será deletado</param>
        void Deletar(int id);
    }
}
