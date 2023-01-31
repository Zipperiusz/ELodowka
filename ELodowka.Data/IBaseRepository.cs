namespace ELodowka.Data;

public interface IBaseRepository<TEntity>
    where TEntity : class, IEntity
{
    Task<List<TEntity>> GetMany();
    Task<List<TProjectTo>> GetMany<TProjectTo>();
    Task<TEntity?> Get(long id);
    Task<TProjectTo?> Get<TProjectTo>(long id);
    Task<TEntity> Add(TEntity entity);
    Task<TEntity> Update(TEntity entity);
    Task Delete(long id);
}