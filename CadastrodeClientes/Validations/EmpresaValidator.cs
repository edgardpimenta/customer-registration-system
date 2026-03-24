using CadastrodeClientes.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CadastrodeClientes.Validations
{
    public class EmpresaValidator
    {
        public EmpresaValidator(string cnpj, string RazaoSocial)
        {
            if (string.IsNullOrWhiteSpace(cnpj) || cnpj.Length < 14)
            {
                throw new ArgumentException("CNPJ não pode ser vazio e não pode ser diferente de 11 dígitos.");
            }

            if (string.IsNullOrWhiteSpace(RazaoSocial) || RazaoSocial.Length < 3 || RazaoSocial.Length > 100)

            {
                throw new ArgumentException("Razão Social não pode ser vazia, Razão Social deve ter entre 3 e 100 caracteres. ");
            }

            if (!Regex.IsMatch(RazaoSocial, @"^[a-zA-Z0-9\s]+$"))
            {
                throw new ArgumentException("Razão Social deve conter apenas letras, números e espaços.");
            }

            ///if (TipoDeCliente == TipoDeCliente.PessoaJuridica && string.IsNullOrWhiteSpace(RazaoSocial))
                //throw new ArgumentException("Pessoa Jurídica deve ter Razão Social.");

        }
    }
}