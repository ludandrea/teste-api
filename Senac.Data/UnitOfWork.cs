using System;
using System.Threading.Tasks;
using Senac.Core;
using Senac.Core.Repositories;
using Senac.Data.Repositories;

namespace Senac.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SenacDbContext _context;
        private ColaboradorRepository _colaboradorRepository;
        public UnitOfWork(SenacDbContext context)
        {
            this._context = context;
        }

        public IColaboradorRepository Colaboradores => _colaboradorRepository = _colaboradorRepository ?? new ColaboradorRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}