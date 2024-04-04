using System;
using System.Collections.Generic;
using VagasEmprego.Domain;

namespace VagasEmprego.Application.Interfaces
{
    public interface IEmpregoAppService : IDisposable
    {
        List<Emprego> ObterTodos();
    }
}