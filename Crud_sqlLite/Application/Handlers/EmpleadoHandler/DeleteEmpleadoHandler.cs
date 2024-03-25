using Business.Contract;
using Common.Utilities.Services;
using Crud_sqlLite.Infraestructure.Commands.EmpleadosCommand;
using Crud_sqlLite.Infraestructure.Commands.TipoPermisosCommand;
using MediatR;
using Models.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Crud_sqlLite.Application.Handlers.EmpleadoHandler
{
    public class DeleteEmpleadoHandler : IRequestHandler<DeleteEmpleadoCommand, Response<bool>>
    {
        private readonly IEmpleadoService Service;

        public DeleteEmpleadoHandler(IEmpleadoService service)
        {
            Service = service;
        }

        public async Task<Response<bool>> Handle(DeleteEmpleadoCommand request, CancellationToken cancellationToken)
        {
            var responseService = Service.delete(request.id);

            return await responseService;
        }
    }
}
