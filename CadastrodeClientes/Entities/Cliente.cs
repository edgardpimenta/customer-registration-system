using CadastrodeClientes.Enums;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace CadastrodeClientes.Entities
{
    public class Cliente
    {
        #region Propriedades
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; private set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; 
        public DateOnly DataCadastro { get; set; }

        public Guid EmpresaId { get; set; } // Chave estrangeira para a empresa associada ao cliente
        public Empresa Empresa { get; set; } = new();// Propriedade de navegação para a empresa associada ao cliente


        /// <summary>
        /// Aplicando o Enum StatusDoCliente para indicar o status do cliente (Ativo, Inativo, Bloqueado)
        /// </summary>
        public StatusDoCliente Status { get; set; } = StatusDoCliente.Ativo;
        public TipoDeCliente TipoDeCliente { get; set; }

       
        /// <summary>
        /// Regra de Negocio da Domain Cliente.
        /// </summary>
        public void ValidarSePodeCadastrarProduto()
        {
            {
                if (Status == StatusDoCliente.Bloqueado)
                {
                    throw new InvalidOperationException("O cliente está bloqueado e não pode cadastrar produtos.");
                }

                if (Status == StatusDoCliente.Inativo)
                {
                    throw new InvalidOperationException("O cliente está inativo e não pode cadastrar produtos.");
                }

                // futuramente criar uma regra de negocio para Repository para verificar se o CPF já existe no banco de dados
            }
        }


        //Construtores para as propriedades de Cliente (encapsulamento seguro)
        public Cliente() { }
        public Cliente (string Nome)
            {
            this.Nome = Nome;
        }
        }
    }

#endregion
