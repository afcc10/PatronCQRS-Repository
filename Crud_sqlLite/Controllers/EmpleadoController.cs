using Common.Helpers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Common.Utilities.Services;
using Crud_sqlLite.Infraestructure.Commands.EmpleadosCommand;
using Crud_sqlLite.Infraestructure.Queries.EmpleadoQuery;

namespace Crud_sqlLite.Controllers
{
   
    [Route("api/[controller]")]
    public class EmpleadoController : ControllerBase
    {
        #region Propierties
        private readonly IMediator _mediator;
        private readonly ILogger<EmpleadoController> _logger;

        public EmpleadoController(IMediator mediator, ILogger<EmpleadoController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        #endregion

        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(typeof(Response<EmpleadoDto>), StatusCodes.Status200OK)]
        public async Task<Response<EmpleadoDto>> Create(CreateEmpleadoCommand command)
        {
            Response<EmpleadoDto> response;
            try
            {
                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<EmpleadoDto>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }

        [HttpDelete]
        [Route("Delete")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        public async Task<Response<bool>> Delete(DeleteEmpleadoCommand command)
        {
            Response<bool> response;
            try
            {

                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<bool>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }

        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(typeof(Response<EmpleadoDto>), StatusCodes.Status200OK)]
        public async Task<Response<EmpleadoDto>> Update(UpdateEmpleadoCommand command)
        {
            Response<EmpleadoDto> response;
            try
            {

                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<EmpleadoDto>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(Response<IEnumerable<EmpleadoDto>>), StatusCodes.Status200OK)]
        public async Task<Response<IEnumerable<EmpleadoDto>>> GetAll(GetAllEmpleadoQuery command)
        {
            Response<IEnumerable<EmpleadoDto>> response;
            try
            {
                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<EmpleadoDto>>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }

        [HttpGet]
        [Route("GetById")]
        [ProducesResponseType(typeof(Response<EmpleadoDto>), StatusCodes.Status200OK)]
        public async Task<Response<EmpleadoDto>> GetById(GetEmpleadoByIdQuery command)
        {
            Response<EmpleadoDto> response;
            try
            {
                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<EmpleadoDto>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }
    }
}
