using EscolaService.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criando uma lista de alunos");
        //Criando uma lista de alunos
        List<Aluno> alunos = new List<Aluno>
            {
                new Aluno { Nome = "João", Idade = 18 },
                new Aluno { Nome = "Maria", Idade = 20 },
                new Aluno { Nome = "Pedro", Idade = 19 }
            };
        Console.WriteLine("Adicionando notas aos alunos");
        // Adicionando notas aos alunos
        foreach (var aluno in alunos)
        {
            aluno.AdicionarNota(7);
            aluno.AdicionarNota(8);
            aluno.AdicionarNota(9);
        }
        Console.WriteLine("Instanciando disciplina");
        //Instanciado uma nova disciplina
        var disciplina = new Disciplina
        {
            Nome = "Matemática",
            Descricao = "Cálculo diferencial e integral",
            CargaHoraria = 70, 
            ProfessorId = 1
        };
        
        Console.WriteLine("Verifica carga horaria");
        disciplina.VerificarCargaHoraria();
        Console.WriteLine("Mostra informações das disiplinas");
        disciplina.MostrarInformacoes();

