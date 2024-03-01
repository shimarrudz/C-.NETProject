namespace EscolaService.Models
{
	public class Disciplina
	{
		public string Nome { get; set; }
		public string Descricao { get; set;
		public int CargaHoraria { get; set;
		public int ProfessorId { get; set; }
	}

	public void MostrarInformacoes()
	{
		Console.WriteLine($"Disciplina: {Nome}");
		Console.WriteLine($"Descrição: {Descricao}");
		Console.WriteLine($"Carga Horária: {CargaHoraria} horas");
		Console.WriteLine($"ID do Professor: {ProfessorId}");
	}
}


	




