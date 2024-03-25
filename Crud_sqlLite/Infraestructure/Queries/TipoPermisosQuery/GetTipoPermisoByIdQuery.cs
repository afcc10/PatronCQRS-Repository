using Common.Utilities.Services;
using MediatR;
using Models.Models;

namespace Crud_sqlLite.Infraestructure.Queries.TipoPermisosQuery
{
    public record GetTipoPermisoByIdQuery(int Id) : IRequest<Response<TipoPermisoDto>>;
}
