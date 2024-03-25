using Common.Utilities.Services;
using MediatR;
using Models.Models;
using System.Collections.Generic;


namespace Crud_sqlLite.Infraestructure.Queries.PermisoQuery
{
    public record GetAllPermisoQuery : IRequest<Response<IEnumerable<PermisoDto>>>;
}
