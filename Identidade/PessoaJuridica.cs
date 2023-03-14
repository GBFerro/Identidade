using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identidade
{
    internal class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public string FantasyName { get; set; }

        public PessoaJuridica(string name, string address, string phone, string cellphone, string emailAddress, string fantasyName, string cnpj) : base(name, address, phone, cellphone, emailAddress)
        {
            this.FantasyName = fantasyName;
            this.Cnpj = cnpj;
        }


        public string ToString()
        {
            return base.ToString() + "\n" +
                $"Nome Fantasia: {this.FantasyName} \n" + 
                $"CNPJ: {this.Cnpj}";
        }
    }
}
