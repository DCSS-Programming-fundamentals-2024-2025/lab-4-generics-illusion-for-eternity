public interface IWriteRepository<in TEntity, in TKey>
{
    void Add(TEntity entity);
    void Remove(TKey id);
}
