using System;
using System.Collections.Generic;
using VagasEmprego.Domain;

public interface IEmpregoRepository : IDisposable
{
    List<Emprego> ObterTodos();

}
