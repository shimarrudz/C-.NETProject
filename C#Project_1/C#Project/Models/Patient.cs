using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Models
{
    public class Patient
    {
    public string Name { get; set; }
        public string CPF { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Construtor convencional
        public Patient()
        {
            
        }

        // Construtor especializado 
        public Patient(string name, string cpf, DateTime dateOfBirth, string address, string phone, string email)
        {
            Name = name;
            CPF = cpf;
            DateOfBirth = dateOfBirth;
            Address = address;
            Phone = phone;
            Email = email;
        }

        // Método para mostrar os dados do usuário
        public void ShowPatientData()
        {
            Console.WriteLine("Dados do usuário:");
            Console.WriteLine("Nome: " + Name);
            Console.WriteLine("Nascimento: " + DateOfBirth);
            Console.WriteLine("Adress: " + Address);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Email:" + Email);
        }

    }
}
