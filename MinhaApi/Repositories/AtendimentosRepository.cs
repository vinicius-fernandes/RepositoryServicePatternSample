using MinhaApi.Models;

namespace MinhaApi.Repositories
{
    public class AtendimentosRepository : IAtendimentosRepository
    {
        public List<Atendimento> Get()
        {
            var atendimentos = new List<Atendimento>()
            {
                new Atendimento()
                {
                    Id="A",
                    Motivo="Erro em página X",
                    Status="Finalizado"
                },
                new Atendimento()
                {
                    Id="B",
                    Motivo="Erro em página Y",
                    Status="Pendente"
                },
                new Atendimento()
                {
                    Id="C",
                    Motivo="Erro em página Z",
                    Status="Pendente"
                },
            };
            return atendimentos;
        }
    }
}
