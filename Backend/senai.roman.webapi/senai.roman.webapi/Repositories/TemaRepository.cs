using senai.roman.webapi.Contexts;
using senai.roman.webapi.Domains;
using senai.roman.webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.roman.webapi.Repositories
{
    public class TemaRepository : ITemaRepository
    {
        RomanContext ctx = new RomanContext();

        public void Atualizar(int id, Tema TemaAtt)
        {
            Tema TemaBuscado = ctx.Temas.Find(id);

            if (TemaAtt.NomeTema != null)
            {
                TemaBuscado.NomeTema = TemaAtt.NomeTema;
            }

            ctx.Temas.Update(TemaBuscado);
            ctx.SaveChanges();
        }

        public Tema BuscarPorId(int id)
        {
            return ctx.Temas.FirstOrDefault(t => t.IdTema == id);
        }

        public void Cadastrar(Tema NovoTema)
        {
            ctx.Temas.Add(NovoTema);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Tema TemaBuscado = ctx.Temas.Find(id);

            ctx.Temas.Remove(TemaBuscado);
            ctx.SaveChanges();
        }

        public List<Tema> Listar()
        {
            return ctx.Temas.ToList();
        }
    }
}
