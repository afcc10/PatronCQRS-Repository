using Common.Utilities.Services;
using MediatR;
using Models.Models;

namespace Crud_sqlLite.Infraestructure.Commands.EmpleadosCommand
{
    public record CreateEmpleadoCommand(string Nombre,string Apellido,string Departamento, string Email, string Telefono) : IRequest<Response<EmpleadoDto>>;
}
