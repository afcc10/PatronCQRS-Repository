using Common.Utilities.Services;
using MediatR;

namespace Crud_sqlLite.Infraestructure.Commands.PermisoCommand
{
    public record DeletePermisoCommand(int id) : IRequest<Response<bool>>;


}
