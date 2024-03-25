using Business.Contract;
using Common.Utilities.Services;
using DataAccess.Core.Contract;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implement
{
    public class PermisoService : IPermisoService
    {
        private readonly IPermisoRepository _repository;

        public PermisoService(IPermisoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response<PermisoDto>> create(PermisoDto dto)
        {
            var result = await _repository.create(dto);
            return result;
        }

        public async Task<Response<bool>> delete(int id)
        {
            var result = await _repository.delete(id);
            return result;
        }

        public async Task<Response<IEnumerable<PermisoDto>>> GetAll()
        {
            var result = await _repository.GetAll();
            return result;
        }

        public async Task<Response<PermisoDto>> GetById(int id)
        {
            var result = await _repository.GetById(id);
            return result;
        }

        public async Task<Response<PermisoDto>> update(PermisoDto dto)
        {
            var result = await _repository.update(dto);
            return result;
        }
    }
}
