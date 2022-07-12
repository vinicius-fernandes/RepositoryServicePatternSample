using Microsoft.AspNetCore.Mvc;
using MinhaApi.Models;
using MinhaApi.Services;

namespace MinhaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtendimentosController : ControllerBase
    {
        private IAtendimentosService _atendimentoService;
        public AtendimentosController(IAtendimentosService atendimentosService)
        {
            _atendimentoService = atendimentosService;
        }
        // GET: api/<AtendimentosController>
        [HttpGet]
        public List<Atendimento> Get()
        {
            return _atendimentoService.GetAll();
        }

        [HttpGet("Pending")]
        public List<Atendimento> GetPendings()
        {
            return _atendimentoService.GetAllPending();
        }

        [HttpGet("PendingPercentage")]
        public double GetPendingPercentage()
        {
            return _atendimentoService.PendingPercentage();
        }
    }
}
