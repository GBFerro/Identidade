using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Identidade
{
    internal class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public PessoaFisica(string name, string address, string phone, string cellphone, string emailAddress, string cpf) : base(name, address, phone, cellphone, emailAddress)
        {
            this.Cpf = cpf;
        }
        public string ToString()
        {
            return base.ToString() + "\n" + $"CPF: {this.Cpf}";
        }

    }
}
