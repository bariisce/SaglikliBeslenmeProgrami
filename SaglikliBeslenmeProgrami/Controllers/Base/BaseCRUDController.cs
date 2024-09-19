using Business.Services.Base.Interface;
using Core.Results;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Base
{
    public class BaseCRUDController<TEntity, TId, TCreateDTO, TUpdateDTO, TResponseDto> : BaseController
    where TEntity : class
    where TCreateDTO : class
    where TUpdateDTO : class
    where TResponseDto : class
    {
        protected readonly IBaseService<TEntity, TId, TResponseDto> _service;

        public BaseCRUDController(IBaseService<TEntity, TId, TResponseDto> service)
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
        public virtual async Task<ActionResult<Result>> Create([FromBody] TCreateDTO requestDto)
            => await _service.AddFromDtoAsync(requestDto);

        [HttpPut]
        public virtual async Task<ActionResult<Result>> Update(TId id, [FromBody] TUpdateDTO entity)
            => await _service.UpdateAsync(id, entity);

        [HttpDelete]
        public virtual async Task<ActionResult<Result>> Delete(TId id)
            => await _service.DeleteAsync(id);
    }
}
