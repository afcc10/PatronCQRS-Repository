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
    public class DeletePermisoHandler : IRequestHandler<DeletePermisoCommand, Response<bool>>
    {
        private readonly IPermisoService Service;

        public DeletePermisoHandler(IPermisoService service)
        {
            Service = service;
        }

        public async Task<Response<bool>> Handle(DeletePermisoCommand request, CancellationToken cancellationToken)
        {
            var responseService = Service.delete(request.id);

            return await responseService;
        }
    }
}
