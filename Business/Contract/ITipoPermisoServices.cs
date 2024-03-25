using Common.Utilities.Services;
using Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Contract
{
    public interface ITipoPermisoServices
    {
        Task<Response<TipoPermisoDto>> create(TipoPermisoDto dto);

        Task<Response<bool>> delete(int id);

        Task<Response<TipoPermisoDto>> update(TipoPermisoDto dto);

        Task<Response<IEnumerable<TipoPermisoDto>>> GetAll();

        Task<Response<TipoPermisoDto>> GetById(int id);
    }
}
