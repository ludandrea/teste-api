using FluentValidation;
using Senac.Core.Models;

namespace Senac.Api.Validators
{
    public class ColaboradorValidator : AbstractValidator<Colaborador>
    {
        public ColaboradorValidator()
        {
            RuleFor(c => c.Indicador).Must(i => i == 'e' || i == 's').WithMessage("'Indicador' Só pode ser 'e' ou 's'.");
        }
    }
}