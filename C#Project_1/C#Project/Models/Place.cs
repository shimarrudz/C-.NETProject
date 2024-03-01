using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Models
{
    public class Place
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string Phone { get; set; }

        protected List<Place> places = new List<Place>();

        // Método para adicionar um novo endereço à lista de lugares
        virtual protected void AddAddress(Place place)
        {
            Console.WriteLine("Adicionando novo endereço...");
            places.Add(place);
            Console.WriteLine("Endereço adicionado com sucesso.");
        }

        // Método para remover um endereço da lista de lugares
        protected void RemoveAddress(Place place)
        {
            Console.WriteLine("Removendo endereço...");
            places.Remove(place);
            Console.WriteLine("Endereço removido com sucesso.");
        }
    }

}