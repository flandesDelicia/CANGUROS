using Api.Aplication.DTO;
using MediatR;

namespace Api.Aplication.Queries
{
    public class IsItValidQuery : RequestDto, IRequest<string>
    {

    }

    public class IsItValidQueryHandler : IRequestHandler<IsItValidQuery, string>
    {
        public IsItValidQueryHandler() { }
        public async Task<string> Handle(IsItValidQuery request, CancellationToken cancellationToken)
        {
            var resp = "NO";

            if (request.V1 < request.V2)
            {
                if (request.X1 > request.X2)
                    resp = "SI";
            }
            else
            {
                if(request.V1 > request.V2)
                {
                    if (request.X1 < request.X2)
                        resp = "SI";
                }
            }
            return await Task.Run(() => resp, cancellationToken);

        }
    }
}