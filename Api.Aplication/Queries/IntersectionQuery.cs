using Api.Aplication.DTO;
using MediatR;

namespace Api.Aplication.Queries
{
    public class IntersectionQuery : RequestDto, IRequest<string>
    {

    }

    public class IntersectionQueryHandler : IRequestHandler<IntersectionQuery, string>
    {
        public IntersectionQueryHandler() { }
        public async Task<string> Handle(IntersectionQuery request, CancellationToken cancellationToken)
        {
            var resp = "NO HAY INTERSECCION";

            if (request.V1 != request.V2)
                resp = $"EL PUNTO DE ENCUENTRO ESTA EN LA UBICACION {((request.V1 * request.X2) - (request.X1 * request.V2))}";

            return await Task.Run(() => resp, cancellationToken);

        }
    }
}
