using Common.Helpers;
using Common.Utilities.Resource;
using Common.Utilities.Services;
using DataAccess.Core.Contract;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Core.Implements
{
    public class PermisoRepository : IPermisoRepository
    {
        #region Propierties
        private readonly DbCrudContext context;

        public PermisoRepository(DbCrudContext context)
        {
            this.context = context;
        }
        #endregion
        public async Task<Response<PermisoDto>> create(PermisoDto dto)
        {
            Response<PermisoDto> response = new();
            try
            {
                Permisos permisos = new();

                permisos.Motivo = dto.Motivo;
                permisos.Estado = dto.Estado;
                permisos.IdEmpleado = dto.IdEmpleado;
                permisos.FechaSolicitud = dto.FechaSolicitud;
                
                context.Add(permisos);
                context.SaveChanges();

                response = new()
                {
                    Status = true,
                    ObjectResponse = new PermisoDto()
                    {
                        Motivo = permisos.Motivo,
                        Estado = permisos.Estado,
                        IdEmpleado = permisos.IdEmpleado,
                        FechaSolicitud = permisos.FechaSolicitud,
                        Id = permisos.Id
                    },
                    Message = MessageExtension.AddMessageList(Message_es.CreateSucces)
                };

                return await Task.FromResult(response);
            }
            catch (Exception)
            {
                return new Response<PermisoDto>
                {
                    Status = false,
                    ObjectResponse = null,
                    Message = MessageExtension.AddMessageList(Message_es.CreateError)
                };
            }
        }

        public async Task<Response<bool>> delete(int id)
        {
            Response<bool> response = new();
            try
            {
                var permiso = context.Permisos.Where(x => x.Id == id).FirstOrDefault();

                context.Remove(permiso);
                context.SaveChanges();

                response = new()
                {
                    Status = true,
                    ObjectResponse = true,
                    Message = MessageExtension.AddMessageList(Message_es.DeleteSucces)
                };

                return await Task.FromResult(response);
            }
            catch (Exception)
            {
                return new Response<bool>
                {
                    Status = false,
                    ObjectResponse = false,
                    Message = MessageExtension.AddMessageList(Message_es.DeleteError)
                };
            }
        }

        public async Task<Response<IEnumerable<PermisoDto>>> GetAll()
        {
            Response<IEnumerable<PermisoDto>> response = new();
            try
            {
                var permiso = await context.Permisos.ToListAsync();

                if (permiso == null)
                {
                    return new Response<IEnumerable<PermisoDto>>
                    {
                        Status = false,
                        ObjectResponse = null,
                        Message = MessageExtension.AddMessageList(Message_es.ConsultaNotFound)
                    };
                }

                var select = permiso.Select(x => new PermisoDto
                {
                    FechaSolicitud = x.FechaSolicitud,
                    IdEmpleado = x.IdEmpleado,
                    Estado = x.Estado,
                    Motivo = x.Motivo,
                    Id = x.Id
                });

                response = new()
                {
                    Status = true,
                    ObjectResponse = select,
                    Message = MessageExtension.AddMessageList(Message_es.ConsultaExitosa)
                };

                return await Task.FromResult(response);
            }
            catch (Exception)
            {
                return new Response<IEnumerable<PermisoDto>>
                {
                    Status = false,
                    ObjectResponse = null,
                    Message = MessageExtension.AddMessageList(Message_es.ConsultaNotFound)
                };
            }
        }

        public async Task<Response<PermisoDto>> GetById(int id)
        {
            Response<PermisoDto> response = new();
            try
            {
                var permiso = await context.Permisos.Where(x => x.Id == id).FirstOrDefaultAsync();

                if (permiso == null)
                {
                    return new Response<PermisoDto>
                    {
                        Status = false,
                        ObjectResponse = null,
                        Message = MessageExtension.AddMessageList(Message_es.ConsultaNotFound)
                    };
                }

                response = new()
                {
                    Status = true,
                    ObjectResponse = new PermisoDto
                    {
                        Motivo = permiso.Motivo,
                        Estado = permiso.Estado,
                        IdEmpleado = permiso.IdEmpleado,
                        FechaSolicitud = permiso.FechaSolicitud,
                        Id = permiso.Id
                    },
                    Message = MessageExtension.AddMessageList(Message_es.ConsultaExitosa)
                };

                return await Task.FromResult(response);
            }
            catch (Exception)
            {
                return new Response<PermisoDto>
                {
                    Status = false,
                    ObjectResponse = null,
                    Message = MessageExtension.AddMessageList(Message_es.ConsultaNotFound)
                };
            }
        }

        public async Task<Response<PermisoDto>> update(PermisoDto dto)
        {
            Response<PermisoDto> response = new();
            try
            {
                var permiso = context.Permisos.Where(x => x.Id == dto.Id).FirstOrDefault();

                permiso.Motivo = dto.Motivo;
                permiso.Estado = dto.Estado;
                permiso.IdEmpleado = dto.IdEmpleado;
                permiso.FechaSolicitud = dto.FechaSolicitud;               

                context.Update(permiso);
                context.SaveChanges();

                response = new()
                {
                    Status = true,
                    ObjectResponse = new PermisoDto
                    {
                        Id = dto.Id,
                        Motivo = dto.Motivo,
                        Estado = dto.Estado,
                        IdEmpleado = dto.IdEmpleado,
                        FechaSolicitud = dto.FechaSolicitud
                    },
                    Message = MessageExtension.AddMessageList(Message_es.UpdateSucces)
                };

                return await Task.FromResult(response);
            }
            catch (Exception)
            {
                return new Response<PermisoDto>
                {
                    Status = false,
                    ObjectResponse = null,
                    Message = MessageExtension.AddMessageList(Message_es.UpdateError)
                };
            }
        }
    }
}
