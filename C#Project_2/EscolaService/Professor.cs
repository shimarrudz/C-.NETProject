namespace EscolaService.Models
{
	public class Professor {
		public string Nome { get; set;}
		public int HorasSemanaAtual { get; set; } = 40;

		public void RegistrarHoras(int horas)
		{
			HorasSemanaAtual += horas;
		}

		public void VerificarCargaHoraria()
		{
			const int limiteCargaHoraria = 60; 

			if (CargaHoraria >= limiteCargaHoraria)
			{
				Console.WriteLine("A disciplina " + Nome + " tem uma carga horária alta.");
			}
			else
			{
				Console.WriteLine("A disciplina " + Nome + " tem uma carga horária normal.");
			}
		}
	{
	

   