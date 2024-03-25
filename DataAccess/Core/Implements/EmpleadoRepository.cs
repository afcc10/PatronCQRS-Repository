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
using System.Threading.Tasks;

namespace DataAccess.Core.Implements
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        #region Propierties
        private readonly DbCrudContext context;

        public EmpleadoRepository(DbCrudContext context)
        {
            this.context = context;
        }
        #endregion

        public async Task<Response<EmpleadoDto>> create(EmpleadoDto dto)
        {
            Response<EmpleadoDto> response = new();
            try
            {
                Empleados empleado = new();

                empleado.Apellido = dto.Apellido;
                empleado.Telefono = dto.Telefono;
                empleado.Email = dto.Email;
                empleado.Nombre = dto.Nombre;
                empleado.Departamento = dto.Departamento;

                context.Add(empleado);
                context.SaveChanges();

                response = new()
                {
                    Status = true,
                    ObjectResponse = new EmpleadoDto() 
                    { 
                        Apellido = empleado.Apellido, 
                        Departamento = empleado.Departamento, 
                        Email = empleado.Email, 
                        Nombre = empleado.Nombre, 
                        Telefono = empleado.Telefono, 
                        Id = empleado.Id 
                    },
                    Message = MessageExtension.AddMessageList(Message_es.CreateSucces)
                };

                return await Task.FromResult(response);
            }
            catch (Exception)
            {
                return new Response<EmpleadoDto>
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
                var empleado = context.Empleados.Where(x => x.Id == id).FirstOrDefault();

                context.Remove(empleado);
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

        public async Task<Response<IEnumerable<EmpleadoDto>>> GetAll()
        {
            Response<IEnumerable<EmpleadoDto>> response = new();
            try
            {
                var empleados = await context.Empleados.ToListAsync();

                if (empleados == null)
                {
                    return new Response<IEnumerable<EmpleadoDto>>
                    {
                        Status = false,
                        ObjectResponse = null,
                        Message = MessageExtension.AddMessageList(Message_es.ConsultaNotFound)
                    };
                }

                var select = empleados.Select(x => new EmpleadoDto
                {
                    Apellido = x.Apellido,
                    Departamento = x.Departamento,
                    Email = x.Email,
                    Nombre = x.Nombre,
                    Telefono = x.Telefono,
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
                return new Response<IEnumerable<EmpleadoDto>>
                {
                    Status = false,
                    ObjectResponse = null,
                    Message = MessageExtension.AddMessageList(Message_es.ConsultaNotFound)
                };
            }
            throw new System.NotImplementedException();
        }

        public async Task<Response<EmpleadoDto>> GetById(int id)
        {
            Response<EmpleadoDto> response = new();
            try
            {
                var empleado = await context.Empleados.Where(x => x.Id == id).FirstOrDefaultAsync();

                if (empleado == null)
                {
                    return new Response<EmpleadoDto>
                    {
                        Status = false,
                        ObjectResponse = null,
                        Message = MessageExtension.AddMessageList(Message_es.ConsultaNotFound)
                    };
                }

                response = new()
                {
                    Status = true,
                    ObjectResponse = new EmpleadoDto 
                    {
                        Apellido = empleado.Apellido,
                        Departamento = empleado.Departamento,
                        Email = empleado.Email,
                        Nombre = empleado.Nombre,
                        Telefono = empleado.Telefono,
                        Id = empleado.Id
                    },
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

        public async Task<Response<EmpleadoDto>> update(EmpleadoDto dto)
        {
            Response<EmpleadoDto> response = new();
            try
            {
                var empleado = context.Empleados.Where(x => x.Id == dto.Id).FirstOrDefault();

                empleado.Apellido = dto.Apellido;
                empleado.Telefono = dto.Telefono;
                empleado.Email = dto.Email;
                empleado.Nombre = dto.Nombre;
                empleado.Departamento = dto.Departamento;

                context.Update(empleado);
                context.SaveChanges();

                response = new()
                {
                    Status = true,
                    ObjectResponse = new EmpleadoDto 
                    {
                        Apellido = empleado.Apellido,
                        Departamento = empleado.Departamento,
                        Email = empleado.Email,
                        Nombre = empleado.Nombre,
                        Telefono = empleado.Telefono,
                        Id = empleado.Id
                    },
                    Message = MessageExtension.AddMessageList(Message_es.UpdateSucces)
                };

                return await Task.FromResult(response);
            }
            catch (Exception)
            {
                return new Response<EmpleadoDto>
                {
                    Status = false,
                    ObjectResponse = null,
                    Message = MessageExtension.AddMessageList(Message_es.UpdateError)
                };
            }
        }
    }
}
