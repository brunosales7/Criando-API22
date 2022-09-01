namespace VoeAirlines.ViewModels.Piloto
{
    public class AtualizarPilotoViewModel
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public AtualizarPilotoViewModel(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
}