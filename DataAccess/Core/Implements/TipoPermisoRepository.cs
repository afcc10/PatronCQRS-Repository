using Common.Helpers;
using Common.Utilities.Resource;
using Common.Utilities.Services;
using DataAccess.Core.Contract;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Core.Implements
{
    public class TipoPermisoRepository : ITipoPermisoRepository
    {
        #region Propierties
        private readonly DbCrudContext context;

        public TipoPermisoRepository(DbCrudContext context)
        {
            this.context = context;
        }
        #endregion

        public async Task<Response<TipoPermisoDto>> create(TipoPermisoDto dto)
        {
            Response<TipoPermisoDto> response = new();
            try
            {
                TipoPermisos tipoPermisos = new();

                tipoPermisos.Tipo = dto.Tipo;
                context.Add(tipoPermisos);
                context.SaveChanges();

                response = new()
                {
                    Status = true,
                    ObjectResponse = new TipoPermisoDto() { Id = tipoPermisos.Id , Tipo = tipoPermisos.Tipo },
                    Message = MessageExtension.AddMessageList(Message_es.CreateSucces)
                };

                return await Task.FromResult(response);
            }
            catch (Exception)
            {
                return new Response<TipoPermisoDto>
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
                var tipoPermiso = context.TipoPermisos.Where(x => x.Id == id).FirstOrDefault();

                context.Remove(tipoPermiso);
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

        public async Task<Response<IEnumerable<TipoPermisoDto>>> GetAll()
        {
            Response<IEnumerable<TipoPermisoDto>> response = new();
            try
            {
                var tipoPermiso =  await context.TipoPermisos.ToListAsync();

                if (tipoPermiso == null)
                {
                    return new Response<IEnumerable<TipoPermisoDto>>
                    {
                        Status = false,
                        ObjectResponse = null,
                        Message = MessageExtension.AddMessageList(Message_es.ConsultaNotFound)
                    };
                }

                var select = tipoPermiso.Select(x => new TipoPermisoDto
                {
                    Id = x.Id,
                    Tipo = x.Tipo
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
                return new Response<IEnumerable<TipoPermisoDto>>
                {
                    Status = false,
                    ObjectResponse = null,
                    Message = MessageExtension.AddMessageList(Message_es.ConsultaNotFound)
                };
            }
        }

        public async Task<Response<TipoPermisoDto>> GetById(int id)
        {
            Response<TipoPermisoDto> response = new();
            try
            {
                var tipoPermiso = await context.TipoPermisos.Where(x => x.Id == id).FirstOrDefaultAsync();

                if (tipoPermiso == null)
                {
                    return new Response<TipoPermisoDto>
                    {
                        Status = false,
                        ObjectResponse = null,
                        Message = MessageExtension.AddMessageList(Message_es.ConsultaNotFound)
                    };
                }                

                response = new()
                {
                    Status = true,
                    ObjectResponse = new TipoPermisoDto { Id = tipoPermiso.Id, Tipo = tipoPermiso.Tipo },
                    Message = MessageExtension.AddMessageList(Message_es.ConsultaExitosa)
                };

                return await Task.FromResult(response);
            }
            catch (Exception)
            {
                return new Response<TipoPermisoDto>
                {
                    Status = false,
                    ObjectResponse = null,
                    Message = MessageExtension.AddMessageList(Message_es.ConsultaNotFound)
                };
            }
        }

        public async Task<Response<TipoPermisoDto>> update(TipoPermisoDto dto)
        {
            Response<TipoPermisoDto> response = new();
            try
            {
                var tipoPermiso = context.TipoPermisos.Where(x => x.Id == dto.Id).FirstOrDefault();

                tipoPermiso.Tipo = dto.Tipo;                
                context.Update(tipoPermiso);
                context.SaveChanges();

                response = new()
                {
                    Status = true,
                    ObjectResponse = new TipoPermisoDto { Id = tipoPermiso.Id , Tipo = tipoPermiso.Tipo },
                    Message = MessageExtension.AddMessageList(Message_es.UpdateSucces)
                };

                return await Task.FromResult(response);
            }
            catch (Exception)
            {
                return new Response<TipoPermisoDto>
                {
                    Status = false,
                    ObjectResponse = null,
                    Message = MessageExtension.AddMessageList(Message_es.UpdateError)
                };
            }
        }
    }
}
