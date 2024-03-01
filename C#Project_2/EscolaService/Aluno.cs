namespace EscolaService.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<int> Notas { get; set; }

        //Progama para adição de notas 
        public void AdicionarNota(int nota)
        {
            Notas.Add(nota);
        }

    }
}



