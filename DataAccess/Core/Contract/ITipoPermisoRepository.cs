using Common.Utilities.Services;
using Models.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Core.Contract
{
    public interface ITipoPermisoRepository
    {
        Task<Response<TipoPermisoDto>> create(TipoPermisoDto dto);

        Task<Response<bool>> delete(int id);

        Task<Response<TipoPermisoDto>> update(TipoPermisoDto dto);

        Task<Response<IEnumerable<TipoPermisoDto>>> GetAll();

        Task<Response<TipoPermisoDto>> GetById(int id);
    }
}
