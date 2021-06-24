using senai.roman.webapi.Contexts;
using senai.roman.webapi.Domains;
using senai.roman.webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.roman.webapi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        RomanContext ctx = new RomanContext();

        public void Atualizar(int id, TipoUsuario TipoUsuarioAtt)
        {
            TipoUsuario TipoUsuarioBuscado = ctx.TipoUsuarios.Find(id);

            if (TipoUsuarioAtt.TituloTipoUsuario != null)
            {
                TipoUsuarioBuscado.TituloTipoUsuario = TipoUsuarioAtt.TituloTipoUsuario;
            }

            ctx.TipoUsuarios.Update(TipoUsuarioBuscado);
            ctx.SaveChanges();
        }

        public TipoUsuario BuscarPorId(int id)
        {
            return ctx.TipoUsuarios.FirstOrDefault(t => t.IdTipoUsuario == id);
        }

        public void Cadastrar(TipoUsuario NovoTipoUsuario)
        {
            ctx.TipoUsuarios.Add(NovoTipoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TipoUsuario TipoUsuarioBuscado = ctx.TipoUsuarios.Find(id);

            ctx.TipoUsuarios.Remove(TipoUsuarioBuscado);
            ctx.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuarios.ToList();
        }
    }
}
