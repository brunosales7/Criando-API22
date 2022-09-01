namespace VoeAirlines.ViewModels.Piloto
{
    public class AdicionarPilotoViewModel
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }

        public AdicionarPilotoViewModel(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
}