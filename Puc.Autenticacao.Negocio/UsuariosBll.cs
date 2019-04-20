using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Puc.Autenticacao.Entidades;
using Puc.Autenticacao.Entidades.Contratos;
using Puc.Autenticacao.Negocio.Mock;

namespace Puc.Autenticacao.Negocio
{
    public class UsuariosBll
    {
        public IEnumerable<Usuario> ListarUsuarios()
        {
            return UsuariosMock.Usuarios;
        }

        public UsuarioOutput Autenticar(UsuarioInput input)
        {
            var usuario = UsuariosMock.Usuarios.FirstOrDefault(u => u.Id == input.idUsuario);

            var usuarioOutput = new UsuarioOutput();

            if (usuario == null)
            {
                usuarioOutput.StatusAutenticacao = StatusAutenticacao.UsuarioNaoEncontrado;
                usuarioOutput.Mensagem = $"Usuário não encontrado com o ID {input.idUsuario}";
            }
            else if (usuario.Senha != input.Senha)
            {
                usuarioOutput.StatusAutenticacao = StatusAutenticacao.SenhaInvalida;
                usuarioOutput.Mensagem = $"Usuário ou senha inválidos";
            }
            else
            {
                usuarioOutput.StatusAutenticacao = StatusAutenticacao.Autenticado;
                usuarioOutput.Mensagem = $"Senha válida";
            }

            return usuarioOutput;
        }
    }
}
