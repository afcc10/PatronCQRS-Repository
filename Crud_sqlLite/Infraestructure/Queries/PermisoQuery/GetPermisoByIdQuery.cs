using Common.Utilities.Services;
using MediatR;
using Models.Models;

namespace Crud_sqlLite.Infraestructure.Queries.PermisoQuery
{
    public record GetPermisoByIdQuery(int Id) : IRequest<Response<PermisoDto>>;
}
