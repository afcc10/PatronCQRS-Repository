using Business.Contract;
using Common.Utilities.Services;
using Crud_sqlLite.Infraestructure.Queries.EmpleadoQuery;
using Crud_sqlLite.Infraestructure.Queries.PermisoQuery;
using Crud_sqlLite.Infraestructure.Queries.TipoPermisosQuery;
using MediatR;
using Models.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Crud_sqlLite.Application.Handlers.PermisoHandler
{
    public class GetPermisoByIdHandler : IRequestHandler<GetPermisoByIdQuery, Response<PermisoDto>>
    {
        private readonly IPermisoService Service;

        public GetPermisoByIdHandler(IPermisoService service)
        {
            Service = service;
        }

        public async Task<Response<PermisoDto>> Handle(GetPermisoByIdQuery request, CancellationToken cancellationToken)
        {
            var responseService = Service.GetById(request.Id);

            return await responseService;
        }
    }
}
