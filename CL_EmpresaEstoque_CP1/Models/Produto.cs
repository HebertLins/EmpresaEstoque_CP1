using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_EmpresaEstoque_CP1.Models
{
    public class Produto
    {
        public int id_produto { get; set; }
        public string nm_produto { get; set; }
        public int qtd_produto { get; set; }
        public float preco_produto { get; set; }
        public string desc_produto { get; set; }
        public TipoProduto tp_produto { get; set; }


        public Produto()
        {
        }

        public Produto(int id_produto, string nm_produto, int qtd_produto, float preco_produto, string desc_produto, TipoProduto tp_produto)
        {
            this.id_produto = id_produto;
            this.nm_produto = nm_produto;
            this.qtd_produto = qtd_produto;
            this.preco_produto = preco_produto;
            this.desc_produto = desc_produto;
            this.tp_produto = tp_produto;


        }


        // Exemplo de Métodos Protected, Internal, Private. Utilizei eles para comporem um método público que eu posso ultilizar na minha program
        protected static void String1Protected()
        {
            Console.WriteLine("Lista de produtos:");
        }

        private static void MForEachPrivate(List<Produto> listaProdutos)
        {
            foreach (Produto produto in listaProdutos)
            {
                Console.WriteLine($"ID: {produto.id_produto}, Nome: {produto.nm_produto}, Quantidade: {produto.qtd_produto}, Preço: {produto.preco_produto}, Descrição: {produto.desc_produto}");
            }
        }

        internal static void String2Internal()
        {
            Console.WriteLine("Chegamos ao final da Lista!");
        }


        public static void MostraTudo(List<Produto> listaProdutos)
        {
            String1Protected();

            MForEachPrivate(listaProdutos);

            String2Internal();

        }


    }
}
