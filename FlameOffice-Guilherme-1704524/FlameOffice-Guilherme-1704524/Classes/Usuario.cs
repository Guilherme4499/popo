using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlameOffice_Guilherme_1704524.Classes
{
    class Usuario : Login, ILOperacoes
    {
        public string nome { get; set; }

        public string GerarHash()
        {
            string hash = MD5.Create().Hash.ToString();
            return hash;
        }

        public List<object> GerarListausuario()
        {
            List<object> listaUsuario = new List<object>();
            listaUsuario.Add("login");
            listaUsuario.Add("senha");
            return listaUsuario;
        }
    }
}
