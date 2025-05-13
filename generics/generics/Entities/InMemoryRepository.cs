using generics.Interfaces;
namespace generics.Entities
{


   public class InMemoryRepository<TEntity, TKey> :
    IRepository<TEntity, TKey>,
    IReadOnlyRepository<TEntity, TKey>,
    IWriteRepository<TEntity, TKey>
    where TEntity : class, new()
    where TKey : struct
    {
       public Dictionary<TKey, TEntity> keyValuePairs = new Dictionary<TKey, TEntity>();
        public void Add(TKey id, TEntity entity)
        {
            keyValuePairs[id] = entity;
        }
    public void Add(TEntity entity)
    {
        dynamic d = entity;
        keyValuePairs[d.Id] = entity;
    }
        public TEntity Get(TKey id)
        {
            return keyValuePairs[id];
        }
        public IEnumerable<TEntity> GetAll()
        {
            return keyValuePairs.Values;
        }

        public void Remove(TKey id)
        {
            keyValuePairs.Remove(id);
            //throw new NotImplementedException();
        }
    }
}