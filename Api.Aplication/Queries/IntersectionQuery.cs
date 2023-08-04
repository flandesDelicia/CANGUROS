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
            {
                var salto = ((request.X1 - request.X2) / (request.V2 - request.V1));
                var punto = (salto * request.V1) + request.X1;
                if (salto > 0)
                    resp = $"EL PUNTO DE ENCUENTRO ES {punto} Y SE PRODUCE EN EL SALTO {salto}";
            }
            return await Task.Run(() => resp, cancellationToken);

        }
    }
}
