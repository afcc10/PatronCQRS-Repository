using Business.Contract;
using Common.Utilities.Services;
using Crud_sqlLite.Infraestructure.Commands.TipoPermisosCommand;
using MediatR;
using Models.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Crud_sqlLite.Application.Handlers.TipoPermisoHandler
{
    public class UpdateTipoPermisoHandler : IRequestHandler<UpdateTipoPermisoCommand, Response<TipoPermisoDto>>
    {
        private readonly ITipoPermisoServices Service;

        public UpdateTipoPermisoHandler(ITipoPermisoServices service)
        {
            Service = service;
        }

        public async Task<Response<TipoPermisoDto>> Handle(UpdateTipoPermisoCommand request, CancellationToken cancellationToken)
        {
            var responseService = Service.update(new TipoPermisoDto { Id = request.Id, Tipo = request.Tipo });

            return await responseService;
        }
    }
}
