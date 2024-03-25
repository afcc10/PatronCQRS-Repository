using Business.Contract;
using Common.Utilities.Services;
using Crud_sqlLite.Infraestructure.Commands.TipoPermisosCommand;
using MediatR;
using Models.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Crud_sqlLite.Application.Handlers.TipoPermisoHandler
{
    public class DeleteTipoPermisoHandler : IRequestHandler<DeleteTipoPermisoCommand, Response<bool>>
    {
        private readonly ITipoPermisoServices Service;

        public DeleteTipoPermisoHandler(ITipoPermisoServices service)
        {
            Service = service;
        }

        public async Task<Response<bool>> Handle(DeleteTipoPermisoCommand request, CancellationToken cancellationToken)
        {
            var responseService = Service.delete(request.id);

            return await responseService;
        }
    }
}
