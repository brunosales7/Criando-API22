using VoeAirlines.Contexts;
using VoeAirlines.Entities;

using VoeAirlines.ViewModels.Cancelamento;

namespace VoeAirlines.Services
{
    public class CancelamentoService
    {
        private readonly VoeAirlinesContext _context;

        public CancelamentoService(VoeAirlinesContext context)
        {
            _context = context;
        }

        public DetalhesCancelamentoViewModel AdicionarCancelamento(AdicionarCancelamentoViewModel dados)
        {
            var cancelamento = new Cancelamento(dados.Motivo, dados.DataHoraNotificacao, dados.VooId);

            _context.Add(cancelamento);
            _context.SaveChanges();

            return new DetalhesCancelamentoViewModel(cancelamento.Id, cancelamento.Motivo, cancelamento.DataHoraNotificacao, cancelamento.VooId);
        }

        public DetalhesCancelamentoViewModel? AtualizarCancelamento(int id, AtualizarCancelamentoViewModel dados)
        {
            var cancelamento = _context.Cancelamentos.Find(id);
            if (cancelamento != null)
            {
                if (id == cancelamento.Id)
                {
                    cancelamento.Motivo = dados.Motivo;
                    cancelamento.DataHoraNotificacao = dados.DataHoraNotificacao;
                    cancelamento.VooId = dados.VooId;
                    _context.Update(cancelamento);
                    _context.SaveChanges();
                    return new DetalhesCancelamentoViewModel(cancelamento.Id, cancelamento.Motivo, cancelamento.DataHoraNotificacao, cancelamento.VooId);
                }
            }
            return null;
        }

        public IEnumerable<ListarCancelamentoViewModel> ListarCancelamentos()
        {
            return _context.Cancelamentos.Select(x => new ListarCancelamentoViewModel(x.Id, x.Motivo, x.DataHoraNotificacao, x.VooId));

        }

        public ListarCancelamentoViewModel? ListarCancelamentoPorId(int id)
        {
            var cancelamento = _context.Cancelamentos.Find(id);
            if (cancelamento != null)
            {
                return new ListarCancelamentoViewModel(cancelamento.Id, cancelamento.Motivo, cancelamento.DataHoraNotificacao, cancelamento.VooId);
            }
            return null;
        }

        public DetalhesCancelamentoViewModel? RemoverCancelamento(int id)
        {
            var cancelamento = _context.Cancelamentos.Find(id);
            if (cancelamento != null)
            {
                if (id == cancelamento.Id)
                {
                    _context.Cancelamentos.Remove(cancelamento);
                    _context.SaveChanges();
                    return new DetalhesCancelamentoViewModel(cancelamento.Id, cancelamento.Motivo, cancelamento.DataHoraNotificacao, cancelamento.VooId);
                }

            }
            return null;

        }
    }
}