using VoeAirlines.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels.Voo;

namespace VoeAirlines.Services
{
    public class VooService
    {
        private readonly VoeAirlinesContext _context;

        public VooService(VoeAirlinesContext context)
        {
            _context = context;
        }

        public DetalhesVooViewModel AdicionarVoo(AdicionarVooViewModel dados)
        {
            var voo = new Voo(dados.Origem, dados.Destino, dados.DataHoraPartida, dados.DataHoraChegada, dados.AeronaveId, dados.PilotoId);
            _context.Add(voo);
            _context.SaveChanges();
            return new DetalhesVooViewModel(voo.Id, voo.Origem, voo.Destino, voo.DataHoraPartida, voo.DataHoraChegada, voo.AeronaveId, voo.PilotoId);
        }

        public DetalhesVooViewModel? AtualizarVoo(int id, AtualizarVooViewModel dados)
        {
            var voo = _context.Voos.Find(id);
            if (voo != null)
            {
                if (id == voo.Id)
                {
                    voo.Origem = dados.Origem;
                    voo.Destino = dados.Destino;
                    voo.DataHoraPartida = dados.DataHoraPartida;
                    voo.DataHoraChegada = dados.DataHoraChegada;
                    voo.AeronaveId = dados.AeronaveId;
                    voo.PilotoId = dados.PilotoId;
                    _context.Update(voo);
                    _context.SaveChanges();
                    return new DetalhesVooViewModel(voo.Id, voo.Origem, voo.Destino, voo.DataHoraPartida, voo.DataHoraChegada, voo.AeronaveId, voo.PilotoId);
                }
            }
            return null;
        }

        public IEnumerable<ListarVooViewModel> ListarVoos()
        {
            return _context.Voos.Select(x => new ListarVooViewModel(x.Id, x.Origem, x.Destino, x.DataHoraPartida, x.DataHoraChegada, x.AeronaveId, x.PilotoId));
        }

        public ListarVooViewModel? ListarPorId(int id)
        {
            var voo = _context.Voos.Find(id);
            if (voo != null)
            {
                return new ListarVooViewModel(voo.Id, voo.Origem, voo.Destino, voo.DataHoraPartida, voo.DataHoraChegada, voo.AeronaveId, voo.PilotoId);
            }
            return null;
        }

        public DetalhesVooViewModel? RemoverVoo(int id)
        {
            var voo = _context.Voos.Find(id);
            if (voo != null)
            {
                if (id == voo.Id)
                {
                    _context.Voos.Remove(voo);
                    _context.SaveChanges();
                    return new DetalhesVooViewModel(voo.Id, voo.Origem, voo.Destino, voo.DataHoraPartida, voo.DataHoraChegada, voo.AeronaveId, voo.PilotoId);
                }
            }
            return null;
        }
    }
}