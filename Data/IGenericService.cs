using System.Collections.Generic;

namespace WeightProgram.Data {
    public interface IGenericService<TEntity> where TEntity : class {
        void Create(TEntity entity);

        TEntity Read(int id);
        IEnumerable<TEntity> ReadAll();

        void Update(TEntity entity);

        void Delete(int id);
    }
}
