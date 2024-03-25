using Business.Contract;
using Common.Utilities.Services;
using Crud_sqlLite.Infraestructure.Commands.EmpleadosCommand;
using Crud_sqlLite.Infraestructure.Commands.PermisoCommand;
using Crud_sqlLite.Infraestructure.Commands.TipoPermisosCommand;
using MediatR;
using Models.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Crud_sqlLite.Application.Handlers.PermisoHandler
{
    public class CreatePermisoHandler : IRequestHandler<CreatePermisoCommand, Response<PermisoDto>>
    {
        private readonly IPermisoService Service;

        public CreatePermisoHandler(IPermisoService service)
        {
            Service = service;
        }

        public async Task<Response<PermisoDto>> Handle(CreatePermisoCommand request, CancellationToken cancellationToken)
        {
            var responseService = Service.create(new PermisoDto
            {
                FechaSolicitud = request.Fechasolicitud,
                IdEmpleado = request.IdEmpleado,
                Estado = request.Estado,
                Motivo = request.Motivo
            });

            return await responseService;
        }
    }
}
