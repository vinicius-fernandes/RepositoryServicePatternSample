using MinhaApi.Models;

namespace MinhaApi.Services
{
    public interface IAtendimentosService
    {
        List<Atendimento> GetAll();
        List<Atendimento> GetAllPending();

        double PendingPercentage();
    }
}
