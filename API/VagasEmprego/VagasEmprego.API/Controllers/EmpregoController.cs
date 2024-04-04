using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VagasEmprego.Domain;
using VagasEmprego.Application.Interfaces;

namespace VagasEmprego.API.Controllers
{
    public class EmpregoController : Controller
    {
        private readonly IEmpregoAppService _empregoAppService;

        public EmpregoController(IEmpregoAppService empregoAppService)
        {
            _empregoAppService = empregoAppService;
        }

        [Route("empregos/v1")]

        [HttpGet]
        [Route("obtertodos")]
        public List<Emprego> ObterTodos()
        {
            return _empregoAppService.ObterTodos();
        }
    }
}
