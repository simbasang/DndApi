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
        public async Task<TModel> Update(Guid id, TRequest request)
        {
            var oldEntity = await _repository.GetById(id);
            if (oldEntity == null)
                return null;

            //update props
            var properties = typeof(TEntity).GetProperties();
            var reqProperties = typeof(TRequest).GetProperties();


            foreach (var prop in properties)
            {
                if (!prop.CanWrite)
                    continue;

                var newValue = reqProperties.FirstOrDefault(x => x.Name == prop.Name)?.GetValue(request);
               
                if (newValue == null)
                    continue;

                prop.SetValue(oldEntity, newValue, null);
            }

            //Must send all the props or it will be 
            return _mapper.Map<TModel>(await _repository.Update(oldEntity));
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.Delete(id);
        }
    }
}

