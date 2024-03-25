using Common.Utilities.Services;
using MediatR;
using Models.Models;
using System;

namespace Crud_sqlLite.Infraestructure.Commands.PermisoCommand
{
    public record CreatePermisoCommand(int IdEmpleado,DateTime Fechasolicitud,string Motivo, string Estado) : IRequest<Response<PermisoDto>>;
}
