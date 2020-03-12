using System;

namespace Senac.Core.Models
{
    public class Colaborador
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTimeOffset Registro { get; set; }
        public char Indicador { get; set; }
    }
}