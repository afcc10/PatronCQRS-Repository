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
    public class CreateEmpleadoHandler : IRequestHandler<CreateEmpleadoCommand, Response<EmpleadoDto>>
    {
        private readonly IEmpleadoService Service;

        public CreateEmpleadoHandler(IEmpleadoService service)
        {
            Service = service;
        }

        public async Task<Response<EmpleadoDto>> Handle(CreateEmpleadoCommand request, CancellationToken cancellationToken)
        {
            var responseService = Service.create(new EmpleadoDto
            {
                Apellido = request.Apellido,
                Departamento = request.Departamento,
                Email = request.Email,
                Nombre = request.Nombre,
                Telefono = request.Telefono
            });

            return await responseService;
        }
    }
}
