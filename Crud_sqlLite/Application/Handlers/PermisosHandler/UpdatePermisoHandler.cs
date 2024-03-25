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
    public class UpdatePermisoHandler : IRequestHandler<UpdatePermisoCommand, Response<PermisoDto>>
    {
        private readonly IPermisoService Service;

        public UpdatePermisoHandler(IPermisoService service)
        {
            Service = service;
        }

        public async Task<Response<PermisoDto>> Handle(UpdatePermisoCommand request, CancellationToken cancellationToken)
        {
            var responseService = Service.update(new PermisoDto
            {
                Motivo = request.Motivo,
                Estado = request.Estado,
                IdEmpleado = request.IdEmpleado,
                FechaSolicitud = request.Fechasolicitud,
                Id = request.Id
            });

            return await responseService;
        }
    }
}
