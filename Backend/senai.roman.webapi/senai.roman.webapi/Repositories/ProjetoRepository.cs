using senai.roman.webapi.Contexts;
using senai.roman.webapi.Domains;
using senai.roman.webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.roman.webapi.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        RomanContext ctx = new RomanContext();

        public void Atualizar(int id, Projeto ProjetoAtt)
        {
            Projeto ProjetoBuscado = ctx.Projetos.Find(id);

            if (ProjetoAtt.NomeProjeto != null)
            {
                ProjetoBuscado.NomeProjeto = ProjetoAtt.NomeProjeto;
            }

            ctx.Projetos.Update(ProjetoBuscado);
            ctx.SaveChanges();
        }

        public Projeto BuscarPorId(int id)
        {
            return ctx.Projetos.FirstOrDefault(t => t.IdProjeto == id);

        }

        public void Cadastrar(Projeto NovoProjeto)
        {
            ctx.Projetos.Add(NovoProjeto);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Projeto ProjetoBuscado = ctx.Projetos.Find(id);

            ctx.Projetos.Remove(ProjetoBuscado);
            ctx.SaveChanges();
        }

        public List<Projeto> Listar()
        {
            return ctx.Projetos.ToList();
        }
    }
}
