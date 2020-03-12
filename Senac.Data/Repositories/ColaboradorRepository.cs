using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Senac.Core.Models;
using Senac.Core.Repositories;

namespace Senac.Data.Repositories
{
    public class ColaboradorRepository : Repository<Colaborador>, IColaboradorRepository
    {
        private SenacDbContext SenacDbContext
        {
            get { return Context as SenacDbContext; }
        }
        public ColaboradorRepository(SenacDbContext context) : base(context)
        { }

        public async Task<IEnumerable<Registro>> GetAllColaboradoresAsync()
        {
            var registrosEntrada = SenacDbContext.Colaboradores.Where(c => c.Indicador == 'e');
            var registros = SenacDbContext.Colaboradores.Where(c => c.Indicador == 's').Select(r =>
                new Registro
                {
                    Nome = r.Nome,
                    Dia = r.Registro.Date.ToString(),
                    HorasTrabalhadas = r.Registro.Hour -
                                       registrosEntrada.FirstOrDefault
                                       (re => re.Nome == r.Nome &&
                                       re.Registro.Date == r.Registro.Date)
                                       .Registro.Hour
                }
            ).OrderBy(o => o.Dia);
            return await registros.ToListAsync();
        }
    }
}