using Artisanaux.Services.ProductAPI.Models.Dto;
using Entraides.Services.NecessiteuxAPI.Models.Dtos;
using Entraides.Services.NecessiteuxAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entraides.Services.NecessiteuxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneoleApiController : ControllerBase
    {
        protected ResponseDto _response;
        private IBenevoleRepository _benevoleRepository;
        public BeneoleApiController(IBenevoleRepository benevoleRepository)
        {
            _benevoleRepository = benevoleRepository;
            this._response = new ResponseDto();
        }
        [HttpGet]
        public async Task<object> Get()
        {
            //try
            {
                IEnumerable<BenevoleDto> benevoleDtos = await _benevoleRepository.GetBenevoles();
                _response.Result = benevoleDtos;
                return _response;
            }
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            BenevoleDto benevoleDto = await _benevoleRepository.GetBenevoleById(id);
            _response.Result = benevoleDto;
            return _response;
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool IsSucess = await _benevoleRepository.DeleteBenevole(id);
                _response.IsSucess = IsSucess;
                return _response;
            }
            catch (Exception)
            {
                return false;
            }
        }
        [HttpPost]
        public async Task<object> Post([FromBody] BenevoleDto benevoleDto)
        {
            try
            {
                BenevoleDto p = await _benevoleRepository.CreateUpdateBenevole(benevoleDto);
                return p;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPut]
        public async Task<object> Put([FromBody] BenevoleDto benevoleDto)
        {
            try
            {
                BenevoleDto IsSucess = await _benevoleRepository.CreateUpdateBenevole(benevoleDto);

                return IsSucess;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
