using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Models
{
    public class Hospital : Place 
    {
        public override AddHospitalAddress(Place hospitalPlace)
        {
            AddAddress(hospitalPlace);
            Console.WriteLine("Endereço do hospital adicionado com sucesso!");
        }

        public void RemoveHospitalAddress(Place hospitalPlace) 
        {
            RemoveAddress(hospitalPlace);
            Console.WriteLine("Endereço do hospital removido com sucesso!");
        }
    }
}
