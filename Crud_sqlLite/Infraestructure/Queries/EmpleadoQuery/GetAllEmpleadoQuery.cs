using Common.Utilities.Services;
using MediatR;
using Models.Models;
using System.Collections.Generic;


namespace Crud_sqlLite.Infraestructure.Queries.EmpleadoQuery
{
    public record GetAllEmpleadoQuery : IRequest<Response<IEnumerable<EmpleadoDto>>>;
}
