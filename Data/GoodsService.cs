using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WeightProgram.Data {
    public class WarehouseService : IGenericService<Warehouse> {
        private readonly WeightProgramModelContainer m_DbContext;

        public WarehouseService(WeightProgramModelContainer ctx) {
            m_DbContext = ctx;
        }

        public void Create(Warehouse wh) {
            m_DbContext.Warehouses.Add(wh);
            m_DbContext.SaveChanges();
        }

        public Warehouse Read(int id) {
            return m_DbContext.Warehouses.Find(id);
        }
        public IEnumerable<Warehouse> ReadAll() {
            return m_DbContext.Warehouses.ToList();
        }

        public void Update(Warehouse wh) {
            m_DbContext.Entry(wh).State = EntityState.Modified;
            m_DbContext.SaveChanges();
        }

        public void Delete(int id) {
            var wh = m_DbContext.Warehouses.Find(id);
            if(wh != null) {
                m_DbContext.Warehouses.Remove(wh);
                m_DbContext.SaveChanges();
            }
        }

        public int GetLastPrimaryKey() {
            // TODO: Optimize
            return m_DbContext.Warehouses.Any() ? m_DbContext.Warehouses.Max(c => c.Id) : 0;
        }
    }
}