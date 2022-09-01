namespace VoeAirlines.ViewModels.Piloto
{
    public class DetalhesPilotoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public DetalhesPilotoViewModel(int id, string nome, string matricula)
        {
            Id = id;
            Nome = nome;
            Matricula = matricula;
        }
    }
}