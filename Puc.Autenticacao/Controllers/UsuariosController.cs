using Puc.Autenticacao.Entidades;
using Puc.Autenticacao.Entidades.Contratos;
using Puc.Autenticacao.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Puc.Autenticacao.Controllers
{
    public class UsuariosController : ApiController
    {
        UsuariosBll _usuariosBll = new UsuariosBll();

        public IEnumerable<Usuario> Get()
        {
            //Método criado apenas para efeitos de testes. Estes dados não seriam expostos em uma aplicação real.
            return _usuariosBll.ListarUsuarios();
        }

        public UsuarioOutput Post(UsuarioInput input)
        {
            return _usuariosBll.Autenticar(input);
        }
    }
}
