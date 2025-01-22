using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WeightProgram.Data {
    public class ReceiptService : IGenericService<Receipt> {
        private readonly WeightProgramModelContainer m_DbContext;

        public ReceiptService(WeightProgramModelContainer ctx) {
            m_DbContext = ctx;
        }

        public void Create(Receipt receipt) {
            m_DbContext.Receipts.Add(receipt);
            receipt.Evaluate();
            m_DbContext.SaveChanges();
        }

        public Receipt Read(int id) {
            return m_DbContext.Receipts.Find(id);
        }
        public IEnumerable<Receipt> ReadAll() {
            return m_DbContext.Receipts.ToList();
        }

        public void Update(Receipt receipt) {
            m_DbContext.Entry(receipt).State = EntityState.Modified;
            m_DbContext.SaveChanges();
        }

        public void Delete(int id) {
            var receipt = m_DbContext.Receipts.Find(id);
            if(receipt != null) {
                m_DbContext.Receipts.Remove(receipt);
                m_DbContext.SaveChanges();
            }
        }
        
        public int GetLastPrimaryKey() {
            // TODO: Optimize
            return m_DbContext.Receipts.Any() ? m_DbContext.Receipts.Max(c => c.Id) : 0;
        }
    }
}