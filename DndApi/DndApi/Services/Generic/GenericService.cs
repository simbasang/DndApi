using AutoMapper;
using Azure.Core;
using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Repos.Generic;

namespace DndApi.Services.Generic
{
    public class GenericService<T, Trepo, Tentity, Trequest, Tmodel, Tquery> : IGenericService<T, Trepo, Tentity, Trequest, Tmodel, Tquery> where T : class
    {
        private readonly IGenericRepo<T, Tentity, Tquery> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepo<T, Tentity, Tquery> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Tmodel>> Get(Tquery query)
        {
            return _mapper.Map<IEnumerable<Tmodel>>(await _repository.Get(query));
        }

        public async Task<Tmodel> Create(Trequest request)
        {
            return _mapper.Map<Tmodel>(await _repository.Create(_mapper.Map<Tentity>(request)));
        }
        public async Task<Tmodel> Update(Trequest request)
        {
            return _mapper.Map<Tmodel>(await _repository.Create(_mapper.Map<Tentity>(request)));
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.Delete(id);
        }
    }
}

