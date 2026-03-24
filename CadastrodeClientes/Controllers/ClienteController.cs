using CadastrodeClientes.Entities;
using CadastrodeClientes.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastrodeClientes.Controllers
{
    public class ClienteController
    {
         public void CadastrarClientes()
        {
            Console.WriteLine("\nCADASTRO DE CLIENTES:\n");

            //Criando objeto cliente e solicitando os dados do cliente
            var cliente = new Cliente();
            Cliente c = cliente; 


            Console.WriteLine("Informe o Nome do Cliente:", cliente.Nome);

            Console.WriteLine("Informe o Cpf do cliente....:");

            Console.WriteLine("Data de cadastro (dd/MM/yyyy)....:");
            cliente.DataCadastro = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo de Cliente....:");
            cliente.TipoDeCliente = (TipoDeCliente) int.Parse(Console.ReadLine());
            Console.WriteLine("\t(1) Pessoa Fisica");
            Console.WriteLine("\t(2) Pessoa Juridica");

           
            var empresa = new Empresa();
            cliente.Empresa = empresa;
            Console.WriteLine(cliente.Empresa.RazaoSocial);

        }

}
}
