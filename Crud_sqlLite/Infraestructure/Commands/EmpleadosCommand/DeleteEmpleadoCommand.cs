using Common.Utilities.Services;
using MediatR;

namespace Crud_sqlLite.Infraestructure.Commands.EmpleadosCommand
{
    public record DeleteEmpleadoCommand(int id) : IRequest<Response<bool>>;


}
