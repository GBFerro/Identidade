using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Identidade
{
    internal class Pessoa
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Cellphone { get; set; }
        public string EmailAddress { get; set; }

        public Pessoa(string name, string address, string phone, string cellphone, string emailAddress) 
        { 
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Cellphone = cellphone;
            this.EmailAddress = emailAddress;
        }

        public string ToString()
        {
            return $"Nome: {this.Name} \n" +
                $"Endereço: {this.Address} \n" +
                $"Telefone: {this.Phone} \n" +
                $"Celular: {this.Cellphone} \n" +
                $"Email: {this.EmailAddress} \n";
        }
    }
}
