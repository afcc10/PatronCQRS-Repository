using Common.Utilities.Services;
using MediatR;

namespace Crud_sqlLite.Infraestructure.Commands.TipoPermisosCommand
{
    public record DeleteTipoPermisoCommand(int id) : IRequest<Response<bool>>;


}
