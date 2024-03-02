using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_EmpresaEstoque_CP1.Models
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string login_usuario { get; set; }
        public string senha_usuario { get; set; }
        public string permissao_usuario { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id_usuario, string login_usuario, string senha_usuario, string permissao_usuario)
        {
            this.id_usuario = id_usuario;
            this.login_usuario = login_usuario;
            this.senha_usuario = senha_usuario;
            this.permissao_usuario = permissao_usuario;
        }
    }
}
