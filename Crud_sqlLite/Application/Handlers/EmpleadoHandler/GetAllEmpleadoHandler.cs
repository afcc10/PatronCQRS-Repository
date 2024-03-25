using Business.Contract;
using Common.Utilities.Services;
using Crud_sqlLite.Infraestructure.Queries.EmpleadoQuery;
using Crud_sqlLite.Infraestructure.Queries.TipoPermisosQuery;
using MediatR;
using Models.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Crud_sqlLite.Application.Handlers.EmpleadoHandler
{
    public class GetAllEmpleadoHandler : IRequestHandler<GetAllEmpleadoQuery, Response<IEnumerable<EmpleadoDto>>>
    {
        private readonly IEmpleadoService Service;

        public GetAllEmpleadoHandler(IEmpleadoService service)
        {
            Service = service;
        }

        public async Task<Response<IEnumerable<EmpleadoDto>>> Handle(GetAllEmpleadoQuery request, CancellationToken cancellationToken)
        {
            var responseService = Service.GetAll();

            return await responseService;
        }
    }
}
