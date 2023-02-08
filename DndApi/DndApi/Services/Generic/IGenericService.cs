namespace DndApi.Services.Generic
{
    public interface IGenericService<TEntity, TRequest, TModel, TQuery> 
        where TEntity : class
        where TRequest : class
        where TModel : class
        where TQuery : class
    {
        Task<TModel> Create(TRequest request);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<TModel>> Get(TQuery query);
        Task<TModel> Update(Guid id,TRequest request);
    }
}
