using Common.Utilities.Services;
using MediatR;
using Models.Models;
using System;

namespace Crud_sqlLite.Infraestructure.Commands.PermisoCommand
{
    public record UpdatePermisoCommand(int Id, int IdEmpleado, DateTime Fechasolicitud, string Motivo, string Estado) : IRequest<Response<PermisoDto>>;
}
