using Common.Utilities.Services;
using Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Core.Contract
{
    public interface IEmpleadoRepository
    {
        Task<Response<EmpleadoDto>> create(EmpleadoDto dto);

        Task<Response<bool>> delete(int id);

        Task<Response<EmpleadoDto>> update(EmpleadoDto dto);

        Task<Response<IEnumerable<EmpleadoDto>>> GetAll();

        Task<Response<EmpleadoDto>> GetById(int id);
    }
}
