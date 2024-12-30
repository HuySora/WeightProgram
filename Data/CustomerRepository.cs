using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WeightProgram.Data {
    public class CustomerRepository : ICustomerRepository {
        private readonly WeightProgramContext m_DbContext;

        public CustomerRepository() {
            m_DbContext = new WeightProgramContext();
        }

        public void Create(Customer customer) {
            m_DbContext.Customers.Add(customer);
            m_DbContext.SaveChanges();
        }

        public Customer Read(int id) {
            return m_DbContext.Customers.Find(id);
        }
        public IEnumerable<Customer> ReadAll() {
            return m_DbContext.Customers.ToList();
        }

        public void Update(Customer customer) {
            m_DbContext.Entry(customer).State = EntityState.Modified;
            m_DbContext.SaveChanges();
        }

        public void Delete(int id) {
            var customer = m_DbContext.Customers.Find(id);
            if(customer != null) {
                m_DbContext.Customers.Remove(customer);
                m_DbContext.SaveChanges();
            }
        }
    }
}