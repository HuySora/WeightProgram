using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WeightProgram.Data {
    public class GoodsService : IGenericService<Goods> {
        private readonly WeightProgramModelContainer m_DbContext;

        public GoodsService(WeightProgramModelContainer ctx) {
            m_DbContext = ctx;
        }

        public void Create(Goods goods) {
            m_DbContext.Goods.Add(goods);
            m_DbContext.SaveChanges();
        }

        public Goods Read(int id) {
            return m_DbContext.Goods.Find(id);
        }
        public IEnumerable<Goods> ReadAll() {
            return m_DbContext.Goods.ToList();
        }

        public void Update(Goods goods) {
            m_DbContext.Entry(goods).State = EntityState.Modified;
            m_DbContext.SaveChanges();
        }

        public void Delete(int id) {
            var goods = m_DbContext.Goods.Find(id);
            if(goods != null) {
                m_DbContext.Goods.Remove(goods);
                m_DbContext.SaveChanges();
            }
        }

        public int GetLastPrimaryKey() {
            // TODO: Optimize
            return m_DbContext.Goods.Any() ? m_DbContext.Goods.Max(c => c.Id) : 0;
        }
    }
}