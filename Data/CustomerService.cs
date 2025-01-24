using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WeightProgram.Data {
    public class CustomerService : IGenericService<Customer> {
        private readonly WeightProgramModelContainer m_DbContext;

        public CustomerService(WeightProgramModelContainer ctx) {
            m_DbContext = ctx;
        }

        public void Create(Customer cust) {
            m_DbContext.Customers.Add(cust);
            m_DbContext.SaveChanges();
        }

        public Customer Read(int id) {
            return m_DbContext.Customers.Find(id);
        }
        public IEnumerable<Customer> ReadAll() {
            return m_DbContext.Customers.ToList();
        }

        public void Update(Customer cust) {
            m_DbContext.Entry(cust).State = EntityState.Modified;
            m_DbContext.SaveChanges();
        }

        public void Delete(int id) {
            var cust = m_DbContext.Customers.Find(id);
            if(cust != null) {
                m_DbContext.Customers.Remove(cust);
                m_DbContext.SaveChanges();
            }
        }

        public int GetLastPrimaryKey() {
            // TODO: Optimize
            return m_DbContext.Customers.Any() ? m_DbContext.Customers.Max(c => c.Id) : 0;
        }
    }
}