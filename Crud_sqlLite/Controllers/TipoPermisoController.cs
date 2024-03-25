using Common.Helpers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Models;
using System.Threading.Tasks;
using System;
using Common.Utilities.Services;
using System.Collections.Generic;
using Crud_sqlLite.Infraestructure.Commands.TipoPermisosCommand;
using Crud_sqlLite.Infraestructure.Queries.TipoPermisosQuery;

namespace Crud_sqlLite.Controllers
{
    
    [Route("api/[controller]")]
    public class TipoPermisoController : ControllerBase
    {
        #region Propierties
        private readonly IMediator _mediator;
        private readonly ILogger<TipoPermisoController> _logger;


        #endregion

        public TipoPermisoController(IMediator mediator, ILogger<TipoPermisoController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(typeof(Response<TipoPermisoDto>), StatusCodes.Status200OK)]
        public async Task<Response<TipoPermisoDto>> Create(CreateTipoPermisosCommand command)
        {
            Response<TipoPermisoDto> response;
            try
            {              

                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<TipoPermisoDto>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }

        [HttpDelete]
        [Route("Delete")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        public async Task<Response<bool>> Delete(DeleteTipoPermisoCommand command)
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
        [ProducesResponseType(typeof(Response<TipoPermisoDto>), StatusCodes.Status200OK)]
        public async Task<Response<TipoPermisoDto>> Update(UpdateTipoPermisoCommand command)
        {
            Response<TipoPermisoDto> response;
            try
            {

                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<TipoPermisoDto>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(Response<IEnumerable<TipoPermisoDto>>), StatusCodes.Status200OK)]
        public async Task<Response<IEnumerable<TipoPermisoDto>>> GetAll(GetAllTipoPermisoQuery command)
        {
            Response<IEnumerable<TipoPermisoDto>> response;
            try
            {
                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<TipoPermisoDto>>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }

        [HttpGet]
        [Route("GetById")]
        [ProducesResponseType(typeof(Response<TipoPermisoDto>), StatusCodes.Status200OK)]
        public async Task<Response<TipoPermisoDto>> GetById(GetTipoPermisoByIdQuery command)
        {
            Response<TipoPermisoDto> response;
            try
            {
                response = await _mediator.Send(command);
                return response;
            }
            catch (Exception ex)
            {
                return new Response<TipoPermisoDto>
                {
                    Status = false,
                    Message = MessageExtension.AddMessageList(ex.Message)
                };
            }

        }
    }
}
