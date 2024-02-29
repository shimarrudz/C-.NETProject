using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Models
{
    public class Professional
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Specialty { get; set; }
        public string CRM { get; set; }

        // Construtor básico
        public Professional(string name, string cpf)
        {
            Name = name;
            CPF = cpf;
        }

        // Construtor que chama outro construtor
        public Professional(string name, string cpf, string specialty, string crm) : this(name, cpf)
        {
            Specialty = specialty;
            CRM = crm;
        }
    }
}