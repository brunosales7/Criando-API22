using VoeAirlines.Entities.Enums;

namespace VoeAirlines.Entities
{
    public class Manutencao
    {
        public Manutencao(DateTime dataHora,TipoManutencao tipoManutencao , int aeronaveId, string? observacao = null)
        {

            DataHora = dataHora;            
            AeronaveId = aeronaveId;
            this.TipoManutencao = tipoManutencao;
            Observacao = observacao;
        }
        
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public TipoManutencao TipoManutencao { get; set; }
        public string? Observacao { get; set; }
        public int AeronaveId { get; set; }
       
        public Aeronave Aeronave { get; set; } = null!;
    }
}