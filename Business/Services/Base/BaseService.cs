using Business.Services.Base.Interface;
using Business.Utilities.Mapping.Interfaces;
using Core.Results;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Base
{
    public abstract class BaseService<TEntity, TId, TResponseDto> :
        IBaseService<TEntity, TId, TResponseDto>
        where TEntity : class
        where TResponseDto : class
    {
        protected readonly IMapperHelper MapperHelper;
        private readonly IRepository<TEntity, TId> _repository;
        protected readonly IUnitOfWork UnitOfWork;

        public BaseService(IUnitOfWork unitOfWork, IRepository<TEntity, TId> repository, IMapperHelper mapperHelper)
        {
            UnitOfWork = unitOfWork;
            _repository = repository;
            MapperHelper = mapperHelper;
        }

        public virtual async Task<DataResult<TResponseDto>> GetByIdAsync(TId id)
        {
            TEntity entity = await _repository.GetByIdAsync(id);
            TResponseDto responseDto = MapperHelper.Map<TResponseDto>(entity);
            return new DataResult<TResponseDto>(responseDto);
        }

        public virtual async Task<DataResult<IList<TResponseDto>>> GetAllAsync()
        {
            IList<TEntity> entities = await _repository.GetAllAsync();
            IList<TResponseDto> mappedEntities = MapperHelper.Map<IList<TResponseDto>>(entities);
            return new DataResult<IList<TResponseDto>>(mappedEntities);
        }

        public virtual async Task<Result> AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await UnitOfWork.CommitAsync();
            return new Result(Messages.SuccessfullyCreatedEntity, ResultStatus.Ok);
        }

        public virtual async Task<Result> AddFromDtoAsync(object entityDto)
        {
            TEntity entity = MapperHelper.Map<TEntity>(entityDto);
            await _repository.AddAsync(entity);
            await UnitOfWork.CommitAsync();
            return new Result(Messages.SuccessfullyCreatedEntity, ResultStatus.Ok);
        }

        public virtual async Task<Result> UpdateAsync(TId id, object entityDto)
        {
            TEntity entity = await _repository.GetByIdAsync(id);

            MapperHelper.Map(entityDto, entity);
            _repository.Update(entity);
            await UnitOfWork.CommitAsync();
            return new Result(Messages.SuccessfullyUpdatedEntity, ResultStatus.Ok);
        }

        public virtual async Task<Result> DeleteAsync(TId id)
        {
            await _repository.RemoveByIdAsync(id);
            await UnitOfWork.CommitAsync();
            return new Result(Messages.SuccessfullyDeletedEntity, ResultStatus.Ok);
        }

    }
}
