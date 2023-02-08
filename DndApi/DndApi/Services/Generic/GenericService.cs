using AutoMapper;
using DndApi.Entitys.Interfaces;
using DndApi.Repos.Generic;

namespace DndApi.Services.Generic
{
    public abstract class GenericService<TRepo, TEntity, TRequest, TModel, TQuery>
        : IGenericService<TEntity, TRequest, TModel, TQuery>
        where TEntity : class, IEntity
        where TRequest : class
        where TModel : class
        where TQuery : class
        where TRepo : GenericRepo<TEntity, TQuery>

    {
        private readonly TRepo _repository;
        private readonly IMapper _mapper;

        public GenericService(TRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TModel>> Get(TQuery query)
        {
            return _mapper.Map<IEnumerable<TModel>>(await _repository.Get(query));
        }

        public async Task<TModel> Create(TRequest request)
        {
            return _mapper.Map<TModel>(await _repository.Create(_mapper.Map<TEntity>(request)));
        }
        public async Task<TModel> Update(TRequest request)
        {
            return _mapper.Map<TModel>(await _repository.Create(_mapper.Map<TEntity>(request)));
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.Delete(id);
        }
    }
}

