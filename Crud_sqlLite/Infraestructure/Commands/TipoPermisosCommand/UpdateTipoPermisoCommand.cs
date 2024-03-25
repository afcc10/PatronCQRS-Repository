using Common.Utilities.Services;
using MediatR;
using Models.Models;

namespace Crud_sqlLite.Infraestructure.Commands.TipoPermisosCommand
{
    public record UpdateTipoPermisoCommand(int Id, string Tipo) : IRequest<Response<TipoPermisoDto>>;
}
