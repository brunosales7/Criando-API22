namespace VoeAirlines.ViewModels.Aeronave
{
    public class AtualizarAeronaveViewModel
    {      
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Codigo { get; set; }

        public AtualizarAeronaveViewModel(string fabricante, string modelo, string codigo)
        {            
            Fabricante = fabricante;
            Modelo = modelo;
            Codigo = codigo;
        }
    }
}