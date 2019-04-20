using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puc.Autenticacao.Entidades.Contratos
{
    public class UsuarioOutput
    {
        public StatusAutenticacao StatusAutenticacao { get; set; }
        public string Mensagem { get; set; }
    }
}
