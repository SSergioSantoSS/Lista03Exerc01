using Lista03Exercicio01.Entities;
using Lista03Exercicio01.Repositories;
using System;
using System.Collections.Generic;

namespace Lista03Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCADASTRO");
            var fornecedor = new Fornecedor();
            fornecedor.Endereco = new Endereco();
            fornecedor.Produtos = new List<Produto>();

            fornecedor.IdFornecedor = Guid.NewGuid();


            Console.WriteLine("\n Por favor, informe o nome do fornecedor :");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("\n Por favor, informe o Cnpj do fornecedor :");
            fornecedor.Cnpj = Console.ReadLine();

            fornecedor.Endereco.IdEndereco = Guid.NewGuid();

            Console.WriteLine("\n Por favor, informe o logradouro do fornecedor :");
            fornecedor.Endereco.Logradouro = Console.ReadLine();

            Console.WriteLine("\n Por favor, informe o bairro do fornecedor :");
            fornecedor.Endereco.Bairro = Console.ReadLine();

            Console.WriteLine("\n Por favor, informe a cidade do fornecedor :");
            fornecedor.Endereco.Cidade = Console.ReadLine();

            Console.WriteLine("\n Por favor, informe o estado do fornecedor :");
            fornecedor.Endereco.Estado = Console.ReadLine();

            Console.WriteLine("\n Por favor, informe o Cep do fornecedor :");
            fornecedor.Endereco.Cep = Console.ReadLine();

            Console.WriteLine("\n Por favor, informe a Quantidade do Produto :");
            var quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            
            {
                Console.WriteLine("\n INFORMAÇÕES DO PRODUTO");

                var produto = new Produto();
                produto.IdProduto = Guid.NewGuid();

                Console.WriteLine("\n Por favor, informe o nome do produto :");
                produto.Nome = Console.ReadLine();

                Console.WriteLine("\n Por favor, informe a quantidade do produto :");
                produto.Quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("\n Por favor, informe o preço do produto :");
                produto.Preco = double.Parse(Console.ReadLine());

                fornecedor.Produtos.Add(produto);
                Console.WriteLine("\nPRODUTOS CADASTRADOS COM SUCESSO!");

                try
                {
                    var fornecedorRepository = new FornecedorRepository();

                    fornecedorRepository.ExportarXml(fornecedor);
                    fornecedorRepository.ExportarJson(fornecedor);

                    Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");

                }
                catch (Exception e)
                {
                    Console.WriteLine("\nERRO :" + e.Message);
                    
                }
                Console.ReadKey();

            }
        }
    }
}
