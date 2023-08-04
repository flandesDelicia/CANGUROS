using Api.Aplication.Queries;
using FluentValidation;

namespace Api.Aplication.Validator
{
    public class IsItValidCommandValidator:AbstractValidator<IsItValidQuery>
    {
        public IsItValidCommandValidator()
        {
            RuleFor(x => x)
                .Cascade(CascadeMode.Stop)
                .Must(x => x.X1>=0 && x.X1 < x.X2 && x.X2<=10000)
                .WithMessage(" se debe cumplir lo siguiente 0 <= X1 < X2 <= 100000");

            RuleFor(x => x)
               .Cascade(CascadeMode.Stop)
               .Must(x => x.V1 >= 1 && x.V1 <= 10000)
               .WithMessage(" se debe cumplir lo siguiente 1 <= V1 <= 100000");

            RuleFor(x => x)
              .Cascade(CascadeMode.Stop)
              .Must(x => x.V2 >= 1 && x.V2 <= 10000)
              .WithMessage(" se debe cumplir lo siguiente 1 <= V2 <= 100000");
        }
    }
}
