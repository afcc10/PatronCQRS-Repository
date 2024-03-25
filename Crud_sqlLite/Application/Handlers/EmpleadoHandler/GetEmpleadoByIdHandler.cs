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
    public class GetEmpleadoByIdHandler : IRequestHandler<GetEmpleadoByIdQuery, Response<EmpleadoDto>>
    {
        private readonly IEmpleadoService Service;

        public GetEmpleadoByIdHandler(IEmpleadoService service)
        {
            Service = service;
        }

        public async Task<Response<EmpleadoDto>> Handle(GetEmpleadoByIdQuery request, CancellationToken cancellationToken)
        {
            var responseService = Service.GetById(request.Id);

            return await responseService;
        }
    }
}
