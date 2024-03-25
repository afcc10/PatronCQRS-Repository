using Common.Utilities.Services;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contract
{
    public interface IEmpleadoService
    {
        Task<Response<EmpleadoDto>> create(EmpleadoDto dto);

        Task<Response<bool>> delete(int id);

        Task<Response<EmpleadoDto>> update(EmpleadoDto dto);

        Task<Response<IEnumerable<EmpleadoDto>>> GetAll();

        Task<Response<EmpleadoDto>> GetById(int id);
    }
}
