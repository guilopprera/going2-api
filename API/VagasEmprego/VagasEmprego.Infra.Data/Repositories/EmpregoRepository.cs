using System;
using System.Collections.Generic;
using System.Linq;
using VagasEmprego.Domain;
using VagasEmprego.Infra.Data.Context;

public class EmpregoRepository : IEmpregoRepository
{

    private readonly VagaEmpregoContext _context;

    public EmpregoRepository(VagaEmpregoContext context)
    {
        _context = context;
    }
    public List<Emprego> ObterTodos()
    {
        return _context.Empregos.ToList();

    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
