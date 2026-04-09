using CadastrodeClientes.Entities;
using CadastrodeClientes.Enums;
using CadastrodeClientes.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace CadastrodeClientes.Controllers
{
    public class ClienteController
    {
       
        public static void GerenciarProdutos()
        { 

            Console.WriteLine("\nCADASTRO DE CLIENTES:\n");
            Console.WriteLine();


            string nome;

            do
            {
                Console.Write("Informe o Nome do Cliente:");
                nome = Console.ReadLine() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("Nome inválido. Tente novamente.\n");
                }

            } while (string.IsNullOrWhiteSpace(nome));


            Console.WriteLine("Informe o Cpf do cliente....:");
            var cpf = Console.ReadLine() ?? string.Empty;


            Console.WriteLine("Informe o Email do cliente....:");
            var email = Console.ReadLine() ?? string.Empty;


            try
            {
                var cliente = new Cliente(nome,email,cpf);

                Console.WriteLine("\n Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n Erro ao cadastrar cliente: {ex.Message}");
            }


            Console.WriteLine("Data de cadastro (dd/MM/yyyy)....:");



            Console.WriteLine("Informe o tipo de Cliente....:");

            Console.WriteLine("\t(1) Pessoa Fisica");
            Console.WriteLine("\t(2) Pessoa Juridica");


            var empresa = new Empresa();
            //cliente.Empresa = empresa;

        }
        
    }
}