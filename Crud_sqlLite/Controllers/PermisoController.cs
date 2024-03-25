using Common.Helpers;
using Crud_sqlLite.Infraestructure.Commands.EmpleadosCommand;
using Crud_sqlLite.Infraestructure.Queries.EmpleadoQuery;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Common.Utilities.Services;
using Crud_sqlLite.Infraestructure.Commands.PermisoCommand;
using Crud_sqlLite.Infraestructure.Queries.PermisoQuery;

namespace Crud_sqlLite.Controllers
{
    [Route("api/[controller]")]
    public class PermisoController : ControllerBase
    {
        #region Propierties
        private readonly IMediator _mediator;
        private readonly ILogger<PermisoController> _logger;

        public PermisoController(IMediator mediator, ILogger<PermisoController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        #endregion

        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(typeof(Response<PermisoDto>), StatusCodes.Status200OK)]
        public async Task<Response<PermisoDto>> Create(CreatePermisoCommand command)
        {
            Response<PermisoDto> response;
            try
            {
                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<PermisoDto>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }

        [HttpDelete]
        [Route("Delete")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        public async Task<Response<bool>> Delete(DeletePermisoCommand command)
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
        [ProducesResponseType(typeof(Response<PermisoDto>), StatusCodes.Status200OK)]
        public async Task<Response<PermisoDto>> Update(UpdatePermisoCommand command)
        {
            Response<PermisoDto> response;
            try
            {

                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<PermisoDto>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(Response<IEnumerable<PermisoDto>>), StatusCodes.Status200OK)]
        public async Task<Response<IEnumerable<PermisoDto>>> GetAll(GetAllPermisoQuery command)
        {
            Response<IEnumerable<PermisoDto>> response;
            try
            {
                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<PermisoDto>>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }

        [HttpGet]
        [Route("GetById")]
        [ProducesResponseType(typeof(Response<PermisoDto>), StatusCodes.Status200OK)]
        public async Task<Response<PermisoDto>> GetById(GetPermisoByIdQuery command)
        {
            Response<PermisoDto> response;
            try
            {
                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<PermisoDto>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }
    }
}
