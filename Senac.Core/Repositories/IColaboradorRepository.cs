using System.Collections.Generic;
using System.Threading.Tasks;
using Senac.Core.Models;

namespace Senac.Core.Repositories
{
    public interface IColaboradorRepository : IRepository<Colaborador>
    {
        Task<IEnumerable<Registro>> GetAllColaboradoresAsync();
    }
}