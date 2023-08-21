using AutoMapper;
using LibraryManagementApi.Repository.Entity;
using LibraryManagementApi.Service.IService;
using LibraryManagementApi.Service.Model.RequestModel;
using LibraryManagementApi.Service.Model.ResponseModel;
using LibraryManagementApi.Utilities;
using LibraryManagementApi.Utilities.Const;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementApi.Controllers
{
    [ApiController]
    public class TitleController : ControllerBase
    {
        private readonly ITitleService _TitleService;

        private readonly IMapper _mapper;
        public TitleController(ITitleService TitleService, IMapper mapper)
        {
            _TitleService = TitleService;
            _mapper = mapper;
        }

        /// <summary>
        /// Weather forecast object
        /// </summary>
        [HttpGet]
        [Route(WebApiEndPoint.Title.GetAllTitles)]
        public async Task<IActionResult> GetAllTitles(int pageNumber = -1, int pageSize = -1)
        {
            var result = await _TitleService.GetAllObjectAsync(pageNumber, pageSize);
            return Ok(new ReturnResponse<List<TitleResponse>>(_mapper.Map<List<TitleResponse>>(result)));
        }

        [HttpGet]
        [Route(WebApiEndPoint.Title.SearchTitles)]
        public async Task<IActionResult> SearchTitles(string? query, int pageNumber = -1, int pageSize = -1)
        {
            var result = await _TitleService.SearchObjectAsync(query == null ? "" : query, pageNumber, pageSize);

            if (result == null)
                return BadRequest(new ReturnResponse<List<TitleResponse>>(_mapper.Map<List<TitleResponse>>(result)
                    , StatusCodes.Status400BadRequest
                    , message: ReponseMessageConstantsTitle.TITLE_NOT_FOUND));

            return Ok(new ReturnResponse<List<TitleResponse>>(_mapper.Map<List<TitleResponse>>(result)));
        }

        [HttpPost]
        [Route(WebApiEndPoint.Title.CreateTitle)]
        public async Task<IActionResult> CreateTitle(TitleRequest dataRequest)
        {
            var result = await _TitleService.AddObjectAsync(_mapper.Map<TitleEntity>(dataRequest));

            if (result == null)
                return BadRequest(new ReturnResponse<List<TitleResponse>>(_mapper.Map<List<TitleResponse>>(result)
                    , StatusCodes.Status400BadRequest
                    , message: ReponseMessageConstantsTitle.CREATE_TITLE_FAILED));

            return Ok(new ReturnResponse<TitleResponse>(_mapper.Map<TitleResponse>(result)));
        }

        //[HttpPost]
        //[Route(WebApiEndPoint.Title.Upload)]
        //public async Task<IActionResult> UpLoadFile([FromForm] IFormFile file, string id)
        //{
        //    var result = await _photoUploadService.AddPhotoAsync(file, id);
        //    return Ok(result);
        //}

        [HttpPut]
        [Route(WebApiEndPoint.Title.UpdateTitle)]
        public async Task<IActionResult> UpdateTitle(string id, TitleRequest dataRequest)
        {
            dataRequest.Id = id;
            var result = await _TitleService.UpdateObjectAsync(_mapper.Map<TitleEntity>(dataRequest));
            return Ok(new ReturnResponse<TitleResponse>(_mapper.Map<TitleResponse>(result)));
        }

        [HttpDelete]
        [Route(WebApiEndPoint.Title.DeleteTitle)]
        public async Task<IActionResult> DeleteTitle(string id)
        {
            var result = await _TitleService.DeleteObjectSync(id);
            return Ok(new ReturnResponse<TitleResponse>(_mapper.Map<TitleResponse>(result)));
        }
    }
}
