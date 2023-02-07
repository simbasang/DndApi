namespace DndApi.Services.Generic
{
    public interface IGenericService<T, Trepo, Tentity, Trequest, Tmodel, Tquery> where T : class
    {
        Task<Tmodel> Create(Trequest request);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<Tmodel>> Get(Tquery query);
        Task<Tmodel> Update(Trequest request);
    }
}
