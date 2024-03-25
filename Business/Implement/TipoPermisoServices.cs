
using Business.Contract;
using Common.Utilities.Services;
using DataAccess.Core.Contract;
using DataAccess.Core.Implements;
using DataAccess.Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implement
{
    public class TipoPermisoServices : ITipoPermisoServices
    {
        private readonly ITipoPermisoRepository _tipoPermisoRepository;

        public TipoPermisoServices(ITipoPermisoRepository tipoPermisoRepository)
        {
            _tipoPermisoRepository = tipoPermisoRepository;
        }

        public async Task<Response<TipoPermisoDto>> create(TipoPermisoDto dto)
        {
            var result = await _tipoPermisoRepository.create(dto);
            return result;

        }

        public async Task<Response<bool>> delete(int id)
        {
            var result = await _tipoPermisoRepository.delete(id);
            return result;
        }

        public async Task<Response<IEnumerable<TipoPermisoDto>>> GetAll()
        {
            var result = await _tipoPermisoRepository.GetAll();
            return result;
        }

        public async Task<Response<TipoPermisoDto>> GetById(int id)
        {
            var result = await _tipoPermisoRepository.GetById(id);
            return result;
        }

        public async Task<Response<TipoPermisoDto>> update(TipoPermisoDto dto)
        {
            var result = await _tipoPermisoRepository.update(dto);
            return result;
        }
    }
}
