using senai.roman.webapi.Contexts;
using senai.roman.webapi.Domains;
using senai.roman.webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.roman.webapi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        RomanContext ctx = new RomanContext();
        public void Atualizar(int id, Usuario UsuarioAtt)
        {
            Usuario UsuarioBuscado = ctx.Usuarios.Find(id);

            if (UsuarioAtt.IdTipoUsuario != null && UsuarioAtt.NomeUsuario != null && UsuarioAtt.Email != null && UsuarioAtt.Senha != null)
            {
                UsuarioBuscado.IdTipoUsuario = UsuarioAtt.IdTipoUsuario;
                UsuarioBuscado.NomeUsuario = UsuarioAtt.NomeUsuario;
                UsuarioBuscado.Email = UsuarioAtt.Email;
                UsuarioBuscado.Senha = UsuarioAtt.Senha;
            }

            ctx.Usuarios.Update(UsuarioBuscado);
            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(t => t.IdUsuario == id);
        }

        public void Cadastrar(Usuario NovoUsuario)
        {
            ctx.Usuarios.Add(NovoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario UsuarioBuscado = ctx.Usuarios.Find(id);

            ctx.Usuarios.Remove(UsuarioBuscado);
            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(l => l.Email == email && l.Senha == senha);
        }
    }
}
