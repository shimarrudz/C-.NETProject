using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Models
{
    public class Schedule
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }

        // Método que Agenda uma consulta
        private void ScheduleAppointment()
        {
            Console.WriteLine("Agendado com sucesso!");
        }


    }
}