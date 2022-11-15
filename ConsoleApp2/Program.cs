using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static string[,] VENDAS { get; set; } = new string[2, 3];
        public static string[,] PRODUTOS { get; set; } = new string[2, 4];


        static void Main(string[] args)
        {

            int opcaoEscolhida;

            while (true)
            {
                msgMenuIniciar();

                opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

                switch (opcaoEscolhida)
                {
                    case 1:
                        cadastrarProduto();
                        break;

                    case 2:
                        realizarVenda();
                        break;

                    case 3:
                        relatorioDeVendas();
                        break;
                }

            }

        }




        static void relatorioDeVendas()
        {//idProduto - codFunc - valor

            double valorTotal = 0;
            double valorProduto = coletaValorProduto();

            string[,] procRelatorioVendas = new string[VENDAS.GetLength(0), VENDAS.GetLength(1)];



            for (int l = 0; l < VENDAS.GetLength(0); l++)
            {
                Console.WriteLine();

                for (int c = 0; c < VENDAS.GetLength(1); c++)
                {

                switch (c)
                    {
                        case 0:
                            procRelatorioVendas[l,c] = VENDAS[l,0];
                            break;

                        case 1:
                            procRelatorioVendas[l,c] = VENDAS[l,1];
                            break;

                        case 2:
                            procRelatorioVendas[l, c] = Convert.ToString(Convert.ToDouble(VENDAS[l, 2]) * valorProduto);
                            break;
                    }



                }

            }
            
        }

        static void realizarVenda()
        {
            Console.Clear();

            Console.WriteLine("DADOS DE VENDA");

            for (int l = 0; l < VENDAS.GetLength(0); l++)
            {
                for (int c = 0; c < VENDAS.GetLength(1); c++)
                {

                    switch (c)
                    {
                        case 0:
                            Console.WriteLine("Informe o codigo do produto");
                            VENDAS[l, c] = Console.ReadLine();
                            break;

                        case 1:
                            Console.WriteLine("Informe o codigo do funcionario");
                            VENDAS[l, c] = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Informe a quantidade de produtos vendidos");
                            VENDAS[l, c] = Console.ReadLine();
                            break;

                    }
                }

            }
        }


        static void cadastrarProduto()
        {
            Console.Clear();

            int idProduto = 0;

            Console.WriteLine("Para cadastrar o produto informe alguns dados");

            for (int l = 0; l < PRODUTOS.GetLength(0); l++)
            {
                idProduto++;

                for (int c = 0; c < PRODUTOS.GetLength(1); c++)
                {

                    switch (c)
                    {
                        case 0:
                            PRODUTOS[l, c] = Convert.ToString(idProduto);
                            break;

                        case 1:
                            Console.WriteLine("Informe a descricao do produto");
                            PRODUTOS[l, c] = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Informe o valor do produto");
                            PRODUTOS[l, c] = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("Informe a quantidade de produtos");
                            PRODUTOS[l, c] = Console.ReadLine();
                            break;
                    }
                
                }
            }
        }

        static double coletaValorProduto()
        {
            double valorProduto = 0;

           // for (int l = 0; l < PRODUTOS.GetLength(0); l++)
            {
                foreach (double n in VENDAS[VENDAS.GetLength(0), 0])
                {
                    if (n == Convert.ToDouble(PRODUTOS[l, 0]))
                    {
                        valorProduto = Convert.ToDouble(PRODUTOS[l, 2]);
                    }
                }

            }

            return valorProduto;

            }

        static void msgMenuIniciar()
        {

            Console.WriteLine("=-=-=-=-=-=-=-=-= ROUPAS+ =-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine();
            Console.WriteLine("MENU: \n================================================");
            Console.WriteLine("1 - CADASTRAR PRODUTOS");
            Console.WriteLine("2 - REALIZAR UMA VENDA");
            Console.WriteLine("3 - RELATORIO DE VENDAS");
            Console.WriteLine("4 - RELATORIO DE VENDAS POR FUNCIONARIO");
            Console.WriteLine("\n0 - SAIR");

        }













    }
}
