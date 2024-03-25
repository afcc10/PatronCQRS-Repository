using Common.Utilities.Services;
using MediatR;
using Models.Models;

namespace Crud_sqlLite.Infraestructure.Queries.EmpleadoQuery
{
    public record GetEmpleadoByIdQuery(int Id) : IRequest<Response<EmpleadoDto>>;
}
