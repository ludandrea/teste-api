using System.Collections.Generic;
using System.Threading.Tasks;
using Senac.Core;
using Senac.Core.Models;
using Senac.Core.Services;

namespace Senac.Services
{
    public class ColaboradorService : IColaboradorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColaboradorService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Colaborador> CreateColaborador(Colaborador novoColaborador)
        {
            await _unitOfWork.Colaboradores.AddAsync(novoColaborador);
            await _unitOfWork.CommitAsync();
            return novoColaborador;
        }

        public async Task<IEnumerable<Registro>> GetAllColaboradores()
        {
            return await _unitOfWork.Colaboradores.GetAllColaboradoresAsync();
        }
    }
}