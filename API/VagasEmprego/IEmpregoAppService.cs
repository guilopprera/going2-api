using System;
using System.Collections.Generic;

public interface IEmpregoAppService : IDisposable
{
    List<Emprego> ObterTodos();

}
