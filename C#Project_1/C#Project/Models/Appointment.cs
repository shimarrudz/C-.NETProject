using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Models
{
    public class Appointment
    {
        public Patient Patient { get; set; }
        public Professional Professional { get; set; }
        public Hospital Hospital { get; set; }
        public string Status { get; set; }

        // Construtor Especializado
        public Appointment(Patient patient, Professional professional, Hospital hospital)
        {
            Patient = patient;
            Professional = professional;
            Hospital = hospital;
            Status = "Agendada";
        }

        // Método para verificar e exibir o status da consulta
        internal void AppointmentStatus()
        {
            Console.WriteLine("Verificando o status da consulta...");
            if (Status == "Agendada")
            {
                Console.WriteLine("A consulta está agendada.");
            }
            else
            {
                Console.WriteLine("O status da consulta é: " + Status);
            }
        }
    }
}