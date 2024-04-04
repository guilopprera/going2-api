using System;
using System.Collections.Generic;
using VagasEmprego.Application.Interfaces;
using VagasEmprego.Domain;

public class EmpregoAppService : IEmpregoAppService
{

    private readonly IEmpregoRepository _empregoRepository;

    public EmpregoAppService(IEmpregoRepository empregoRepository)
    {
        _empregoRepository = empregoRepository;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    List<Emprego> IEmpregoAppService.ObterTodos()
    {
        return _empregoRepository.ObterTodos();
    }
}
