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
    public class GetAllTipoPermisoHandler : IRequestHandler<GetAllTipoPermisoQuery, Response<IEnumerable<TipoPermisoDto>>>
    {
        private readonly ITipoPermisoServices Service;

        public GetAllTipoPermisoHandler(ITipoPermisoServices service)
        {
            Service = service;
        }

        public async Task<Response<IEnumerable<TipoPermisoDto>>> Handle(GetAllTipoPermisoQuery request, CancellationToken cancellationToken)
        {
            var responseService = Service.GetAll();

            return await responseService;
        }
    }
}
