using Business.Contract;
using Common.Utilities.Services;
using Crud_sqlLite.Infraestructure.Commands.TipoPermisosCommand;
using MediatR;
using Models.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Crud_sqlLite.Application.Handlers.TipoPermisoHandler
{
    public class CreateTipoPermisoHandler : IRequestHandler<CreateTipoPermisosCommand, Response<TipoPermisoDto>>
    {
        private readonly ITipoPermisoServices Service;

        public CreateTipoPermisoHandler(ITipoPermisoServices service)
        {
            Service = service;
        }

        public async Task<Response<TipoPermisoDto>> Handle(CreateTipoPermisosCommand request, CancellationToken cancellationToken)
        {
            var responseService = Service.create(new TipoPermisoDto() { Tipo = request.Tipo });

            return await responseService;
        }
    }
}
