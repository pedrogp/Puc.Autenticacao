using Puc.Autenticacao.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Autenticacao.Negocio.Mock
{
    public static class UsuariosMock
    {
        #region Usuarios

        private static Usuario usuario1 = new Usuario
        {
            Id = 1,
            Nome = "Cliente 1",
            Senha = "123",
        };

        private static Usuario usuario2 = new Usuario
        {
            Id = 2,
            Nome = "Cliente 2",
            Senha = "123",
        };

        private static Usuario usuario3 = new Usuario
        {
            Id = 3,
            Nome = "Cliente 3",
            Senha = "123",
        };

        private static Usuario usuario4 = new Usuario
        {
            Id = 4,
            Nome = "Cliente 4",
            Senha = "123",
        };

        private static Usuario usuario5 = new Usuario
        {
            Id = 5,
            Nome = "Cliente 5",
            Senha = "123",
        };

        #endregion

        public static List<Usuario> Usuarios = new List<Usuario>
        {
            usuario1,
            usuario2,
            usuario3,
            usuario4,
            usuario5,
        };
    }
}
