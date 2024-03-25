using Common.Utilities.Services;
using MediatR;
using Models.Models;
using System.Collections.Generic;


namespace Crud_sqlLite.Infraestructure.Queries.TipoPermisosQuery
{
    public record GetAllTipoPermisoQuery : IRequest<Response<IEnumerable<TipoPermisoDto>>>;
}
