using VoeAirlines.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels.Aeronave;

namespace VoeAirlines.Services
{
    
    public class AeronaveService
    {
        private readonly VoeAirlinesContext _context;

        public AeronaveService(VoeAirlinesContext context)
        {
            _context = context;
        }

        public DetalhesAeronaveViewModel AdicionarAeronave(AdicionarAeronaveViewModel dados)
        {
            var aeronave = new Aeronave(dados.Fabricante, dados.Modelo, dados.Codigo);

            _context.Add(aeronave);
            _context.SaveChanges();

            return new DetalhesAeronaveViewModel(aeronave.Id, aeronave.Fabricante, aeronave.Modelo, aeronave.Codigo);
        }

        public DetalhesAeronaveViewModel? AtualizarAeronave(int id, AtualizarAeronaveViewModel dados)
        {
            var aeronaveParaAtualizar = _context.Aeronaves.Find(id);
            if (aeronaveParaAtualizar != null)
            {
                if (id == aeronaveParaAtualizar.Id)
                {
                    aeronaveParaAtualizar.Fabricante = dados.Fabricante;
                    aeronaveParaAtualizar.Modelo = dados.Modelo;
                    aeronaveParaAtualizar.Codigo = dados.Codigo;
                    _context.Update(aeronaveParaAtualizar);
                    _context.SaveChanges();
                    return new DetalhesAeronaveViewModel(aeronaveParaAtualizar.Id, aeronaveParaAtualizar.Fabricante, aeronaveParaAtualizar.Modelo, aeronaveParaAtualizar.Codigo);
                }
               
            }
            return null;
        }

        public IEnumerable<ListarAeronavesViewModel> ListarAeronaves()
        {
            return _context.Aeronaves.Select(x => new ListarAeronavesViewModel(x.Id, x.Fabricante, x.Modelo, x.Codigo));          
            
        }

        public ListarAeronavesViewModel? ListarAeronavePorId(int id)
        {
            var aeronave = _context.Aeronaves.Find(id);
            if (aeronave != null)
            {
                return new ListarAeronavesViewModel(aeronave.Id,aeronave.Fabricante,aeronave.Modelo,aeronave.Codigo);
            }
            return null;
        }

        public DetalhesAeronaveViewModel? RemoverAeronave(int id)
        {
            var aeronavaParaRemover = _context.Aeronaves.Find(id);
            if (aeronavaParaRemover != null)
            {
                if (id == aeronavaParaRemover.Id)
                {
                    _context.Aeronaves.Remove(aeronavaParaRemover);
                    _context.SaveChanges();
                    return new DetalhesAeronaveViewModel(aeronavaParaRemover.Id, aeronavaParaRemover.Fabricante, aeronavaParaRemover.Modelo, aeronavaParaRemover.Codigo);
                }
                
            }
            return null;
            
        }

    }
}