using MinhaApi.Models;
using MinhaApi.Repositories;

namespace MinhaApi.Services
{
    public class AtendimentosService : IAtendimentosService
    {
        private readonly IAtendimentosRepository _atendimentosRepository;

        public AtendimentosService(IAtendimentosRepository atendimentosRepository)
        {
            _atendimentosRepository = atendimentosRepository;
        }

        public List<Atendimento> GetAll()
        {
            return _atendimentosRepository.Get();
        }

        public List<Atendimento> GetAllPending()
        {
           return _atendimentosRepository.Get().Where(a=>a.Status=="Pendente").ToList();
        }

        public double PendingPercentage()
        {
            if (_atendimentosRepository.Get().Count == 0)
                return 0;

            return _atendimentosRepository.Get().Where(a => a.Status == "Pendente").Count() / _atendimentosRepository.Get().Count;
        }
    }
}
