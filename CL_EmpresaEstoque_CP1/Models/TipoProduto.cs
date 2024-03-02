using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_EmpresaEstoque_CP1.Models
{
    public class TipoProduto
    {
        private int id_tp_produto { get; set; }
        private string desc_tp_produto { get; set; }

        public TipoProduto()
        {
        }

        public TipoProduto(int id_tp_produto, string desc_tp_produto)
        {
            this.id_tp_produto = id_tp_produto;
            this.desc_tp_produto = desc_tp_produto;
        }
    }
}
