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
    public class GetAllPermisoHandler : IRequestHandler<GetAllPermisoQuery, Response<IEnumerable<PermisoDto>>>
    {
        private readonly IPermisoService Service;

        public GetAllPermisoHandler(IPermisoService service)
        {
            Service = service;
        }

        public async Task<Response<IEnumerable<PermisoDto>>> Handle(GetAllPermisoQuery request, CancellationToken cancellationToken)
        {
            var responseService = Service.GetAll();

            return await responseService;
        }
    }
}
