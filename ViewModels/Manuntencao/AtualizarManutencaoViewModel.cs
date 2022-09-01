using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels.Manutencao
{
    public class AtualizarManutencaoViewModel
    {
        public DateTime DataHora { get; set; }
        public TipoManutencao TipoManutencao { get; set; }
        public string? Observacao { get; set; }
        public int AeronaveId { get; set; }

        public AtualizarManutencaoViewModel(DateTime dataHora, TipoManutencao tipoManutencao, string? observacao, int aeronaveId)
        {
            DataHora = dataHora;
            TipoManutencao = tipoManutencao;
            Observacao = observacao;
            AeronaveId = aeronaveId;
        }
    }
}