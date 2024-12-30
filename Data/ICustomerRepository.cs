using System.Collections.Generic;

namespace WeightProgram.Data {
    public interface ICustomerRepository {
        void Create(Customer customer);

        Customer Read(int id);
        IEnumerable<Customer> ReadAll();

        void Update(Customer customer);

        void Delete(int id);
    }
}
