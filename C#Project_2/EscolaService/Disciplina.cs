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
		Console.WriteLine($"Descri��o: {Descricao}");
		Console.WriteLine($"Carga Hor�ria: {CargaHoraria} horas");
		Console.WriteLine($"ID do Professor: {ProfessorId}");
	}
}


	




