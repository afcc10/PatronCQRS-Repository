using Business.Contract;
using Common.Utilities.Services;
using DataAccess.Core.Contract;
using DataAccess.Core.Implements;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implement
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _repository;

        public EmpleadoService(IEmpleadoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response<EmpleadoDto>> create(EmpleadoDto dto)
        {
            var result = await _repository.create(dto);
            return result;
        }

        public async Task<Response<bool>> delete(int id)
        {
            var result = await _repository.delete(id);
            return result;
        }

        public async Task<Response<IEnumerable<EmpleadoDto>>> GetAll()
        {
            var result = await _repository.GetAll();
            return result;
        }

        public async Task<Response<EmpleadoDto>> GetById(int id)
        {
            var result = await _repository.GetById(id);
            return result;
        }

        public async Task<Response<EmpleadoDto>> update(EmpleadoDto dto)
        {
            var result = await _repository.update(dto);
            return result;
        }
    }
}
