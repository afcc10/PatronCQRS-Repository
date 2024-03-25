using Business.Contract;
using Common.Utilities.Services;
using Crud_sqlLite.Infraestructure.Queries.TipoPermisosQuery;
using MediatR;
using Models.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Crud_sqlLite.Application.Handlers.TipoPermisoHandler
{
    public class GetTipoPermisoByIdHandler : IRequestHandler<GetTipoPermisoByIdQuery, Response<TipoPermisoDto>>
    {
        private readonly ITipoPermisoServices Service;

        public GetTipoPermisoByIdHandler(ITipoPermisoServices service)
        {
            Service = service;
        }

        public async Task<Response<TipoPermisoDto>> Handle(GetTipoPermisoByIdQuery request, CancellationToken cancellationToken)
        {
            var responseService = Service.GetById(request.Id);

            return await responseService;
        }
    }
}
