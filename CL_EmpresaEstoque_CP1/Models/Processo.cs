using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_EmpresaEstoque_CP1.Models
{
    public class Processo
    {
        public int id_processo { get; set; }
        public char tipo_processo { get; set; }
        public string desc_processo { get; set; }

        public Processo()
        {
        }

        public Processo(int id_processo, char tipo_processo, string desc_processo)
        {
            this.id_processo = id_processo;
            this.tipo_processo = tipo_processo;
            this.desc_processo = desc_processo;
        }

        public static void TodosProcessos(List<Processo> listaProcessos)
        {
            Console.WriteLine("Lista de processos:");

            foreach (Processo processo in listaProcessos)
            {
                Console.WriteLine($"ID: {processo.id_processo}, Tipo: {processo.tipo_processo}, Descrição: {processo.desc_processo}");
            }
        }

    }
}
