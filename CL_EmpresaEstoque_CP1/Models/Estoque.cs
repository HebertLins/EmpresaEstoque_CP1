using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5 Classes, todas na pasta Models

namespace CL_EmpresaEstoque_CP1.Models
{
    public class Estoque
    {
        public int id_estoque { get; set; }

        public List<Produto> produtos_estoque { get; set; }


//Construtor convencional
        public Estoque()
        {
        }

//Construtor especializado
        public Estoque(int id_estoque, List<Produto> produtos_estoque)
        {
            this.id_estoque = id_estoque;
            this.produtos_estoque = produtos_estoque;
        }

//Construtor que chama outro construtor, basicamente uma junção dos 2 acima
        public Estoque(int id_estoque) : this(id_estoque, new List<Produto>())
        {
        }

    }
}
