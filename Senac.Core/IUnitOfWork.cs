using System;
using System.Threading.Tasks;
using Senac.Core.Repositories;

namespace Senac.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IColaboradorRepository Colaboradores { get; }
        Task<int> CommitAsync();
    }
}