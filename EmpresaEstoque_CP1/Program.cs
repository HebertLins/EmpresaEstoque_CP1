using CL_EmpresaEstoque_CP1.Models;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int id;
        string nm;
        int qtd;
        float preco;
        string desc;
        string tipo; 
        int op;
        int op2;
        int op3;
        string usu;
        string senha;
        string senha_c;
        List<Usuario> ListaUsuarios = new List<Usuario>();
        List<Produto> ListaProdutos = new List<Produto>();
        List<TipoProduto> ListaTpProdutos = new List<TipoProduto>();
        List<Processo> ListaProcessos = new List<Processo>();
        Estoque e = new Estoque();
        Processo p = new Processo(1, 'B', "Transação bancária");
        Processo p2 = new Processo(2, 'E', "Saída de estoque");
        ListaProcessos.Add(p);
        ListaProcessos.Add(p2);


        Usuario testinho = new Usuario(1, "Teste", "123", "Admin");
        ListaUsuarios.Add(testinho); 

        do
        {
            Console.WriteLine("Olá, escolha entre uma dessas opções: ");
            Console.WriteLine("1 - Login");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Sair");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                //Execução USUARIO
                Console.WriteLine("Informe suas informações de cadastro!");
                Console.WriteLine("Digite o seu Usuario: ");
                usu = Console.ReadLine();
                Console.WriteLine("Digite o sua Senha:  ");
                senha = Console.ReadLine();

                foreach (Usuario usuario in ListaUsuarios)
                {
                    //Execução Estrutura de decisão
                    if (usuario.login_usuario.Equals(usu) && usuario.senha_usuario.Equals(senha))
                    {
                        //Execução Processo, Estoque, Produtos e TipoProduto
                        do
                        {
                            Console.WriteLine("Login realizado com sucesso!");
                            Console.WriteLine("Escolha entre uma das opções abaixo:");
                            Console.WriteLine("1 - Criar uma lista de produtos e inserir no estoque");
                            Console.WriteLine("2 - Listar todos produtos cadastrados");
                            Console.WriteLine("3 - Listar todos processos realizados");
                            Console.WriteLine("4 - Sair");
                            op2 = int.Parse(Console.ReadLine());

                            if (op2 == 1) 
                            {
                                //Execução Laço
                                do
                                {
                                    //Explicação do que está sendo executado
                                    Console.WriteLine("Uma lista de produtos está sendo criada!");
                                    Console.WriteLine("Nome do produto:");
                                    nm = Console.ReadLine();
                                    Console.WriteLine("Quantidade do produto:");
                                    qtd = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Preco do produto:");
                                    preco = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Desc do produto:");
                                    desc = Console.ReadLine();
                                    Console.WriteLine("Tipo do produto:");
                                    tipo = Console.ReadLine();


                                    TipoProduto tp = new TipoProduto(ListaTpProdutos.Count + 1, tipo);
                                    ListaTpProdutos.Add(tp);

                                    Produto pr = new Produto(ListaProdutos.Count + 1, nm, qtd, preco, desc, tp);
                                    ListaProdutos.Add(pr);

                                    Console.WriteLine("Deseja continuar cadastrando nessa lista? 1 - Sim / 2 - Não");
                                    op3 = int.Parse(Console.ReadLine());

                                } while(op3 != 2);

                                e.id_estoque = 1;
                                e.produtos_estoque = ListaProdutos;
                                

                            }
                            else if (op2 == 2) 
                            {
                                Produto.MostraTudo(ListaProdutos);

                            }else if (op2 == 3)
                            {
                                Processo.TodosProcessos(ListaProcessos);
                            }


                        } while (op2 != 4);


                    }
                    else
                    {
                    }


                }
            }
            else if (op == 2)
            {
                Console.WriteLine("Digite o Usuario que deseja cadastrar: ");
                usu = Console.ReadLine();
        
                do
                {
                    Console.WriteLine("LEMBRE-SE DE DIGITAR A MESMA SENHA PARA CONFIRMAÇÃO!!!");
                    Console.WriteLine("Digite a Senha que deseja cadastrar: ");
                    senha = Console.ReadLine();
                    Console.WriteLine("Digite a Senha novamente para confirmar: ");
                    senha_c = Console.ReadLine();
                }
                while (senha != senha_c);

                ListaUsuarios.Add(new Usuario(ListaUsuarios.Count + 1, usu, senha, "Admin"));
                Console.WriteLine("Novo usuário cadastrado com sucesso!");


            }
            else if (op == 3)
            {
                Console.WriteLine("O sistema foi encerrado!");
            }
            else
            {
                Console.WriteLine("Essa opção não existe");
            }
        }
        while (op != 3);
    }
}