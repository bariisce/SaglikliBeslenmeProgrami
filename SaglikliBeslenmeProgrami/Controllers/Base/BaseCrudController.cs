using Business.Services.Base.Interface;
using Core.Results;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Base
{
    public class BaseCrudController<TEntity, TId, TCreateDto, TUpdateDto, TResponseDto> : BaseController
    where TEntity : class
    where TCreateDto : class
    where TUpdateDto : class
    where TResponseDto : class
    {
        protected readonly IBaseService<TEntity, TId, TResponseDto> _service;

        public BaseCrudController(IBaseService<TEntity, TId, TResponseDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual async Task<ActionResult<DataResult<IList<TResponseDto>>>> GetAll()
            => await _service.GetAllAsync();

        [HttpGet]
        public virtual async Task<ActionResult<DataResult<TResponseDto>>> GetById(TId id)
            => await _service.GetByIdAsync(id);

        [HttpPost]
        public virtual async Task<ActionResult<Result>> Create([FromBody] TCreateDto requestDto)
            => await _service.AddFromDtoAsync(requestDto);

        [HttpPut]
        public virtual async Task<ActionResult<Result>> Update(TId id, [FromBody] TUpdateDto entity)
            => await _service.UpdateAsync(id, entity);

        [HttpDelete]
        public virtual async Task<ActionResult<Result>> Delete(TId id)
            => await _service.DeleteAsync(id);
    }
}
