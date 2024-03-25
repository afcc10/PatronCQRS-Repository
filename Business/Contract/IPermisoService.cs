using Common.Utilities.Services;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contract
{
    public interface IPermisoService
    {
        Task<Response<PermisoDto>> create(PermisoDto dto);

        Task<Response<bool>> delete(int id);

        Task<Response<PermisoDto>> update(PermisoDto dto);

        Task<Response<IEnumerable<PermisoDto>>> GetAll();

        Task<Response<PermisoDto>> GetById(int id);
    }
}
