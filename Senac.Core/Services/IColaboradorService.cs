using System.Collections.Generic;
using System.Threading.Tasks;
using Senac.Core.Models;

namespace Senac.Core.Services
{
    public interface IColaboradorService
    {
        Task<IEnumerable<Registro>> GetAllColaboradores();
        Task<Colaborador> CreateColaborador(Colaborador novoColaborador);
    }
}