using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Models
{
    public class Hospital : Place 
    {
        // Sobrescreve o método AddAddress da classe base para adicionar um endereço ao hospital
        protected override void AddAddress(Place hospitalPlace)
        {
            Console.WriteLine("Adicionando endereço ao hospital...");
            base.AddAddress(hospitalPlace);
            Console.WriteLine("Endereço do hospital adicionado com sucesso!");
        }

        // Método para remover um endereço do hospital
        public void RemoveHospitalAddress(Place hospitalPlace) 
        {
            Console.WriteLine("Removendo endereço do hospital...");
            RemoveAddress(hospitalPlace);
            Console.WriteLine("Endereço do hospital removido com sucesso!");
        }
    }
}
