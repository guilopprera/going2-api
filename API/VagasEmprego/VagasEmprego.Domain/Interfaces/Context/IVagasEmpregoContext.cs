namespace VagasEmprego.Domain.Interfaces.Context
{
    public interface IVagasEmpregoContext
    {
        int SaveChanges();
        void Dispose();

    }
}
