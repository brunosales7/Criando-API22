namespace VoeAirlines.ViewModels.Piloto
{
    public class AtualizarPilotoViewModel
    {
        public int Id {get; set;}
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public AtualizarPilotoViewModel(int id,string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
            Id = id;
        }
    }
}