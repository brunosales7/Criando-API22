namespace VoeAirlines.ViewModels.Aeronave
{
    public class ListarAeronavesViewModel
    {
        public int Id { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Codigo { get; set; }

        public ListarAeronavesViewModel(int id, string fabricante, string modelo, string codigo)
        {
            Id = id;
            Fabricante = fabricante;
            Modelo = modelo;
            Codigo = codigo;
        }
    }
}