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
        public int Address { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string Phone { get; set; }

        protected List<Place> places = new List<Place>();

        virtual protected void AddAddress(Place place)
        {
            places.Add(place);
            Console.WriteLine("Endereço adicionado!");
        }

        protected void RemoveAddress(Place place)
        {
            places.Remove(place);
            Console.WriteLine("Endereço removido!");
        }

    }

}