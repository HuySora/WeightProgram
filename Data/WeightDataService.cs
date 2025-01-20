using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WeightProgram.Data {
    public class WeightDataService : IGenericService<WeightData> {
        private readonly WeightProgramModelContainer m_DbContext;

        public WeightDataService(WeightProgramModelContainer ctx) {
            m_DbContext = ctx;
        }

        public void Create(WeightData wgtData) {
            m_DbContext.WeightDatum.Add(wgtData);
            wgtData.Evaluate();
            m_DbContext.SaveChanges();
        }

        public WeightData Read(int id) {
            return m_DbContext.WeightDatum.Find(id);
        }
        public IEnumerable<WeightData> ReadAll() {
            return m_DbContext.WeightDatum.ToList();
        }

        public void Update(WeightData wgtData) {
            m_DbContext.Entry(wgtData).State = EntityState.Modified;
            m_DbContext.SaveChanges();
        }

        public void Delete(int id) {
            var wgtData = m_DbContext.WeightDatum.Find(id);
            if(wgtData != null) {
                m_DbContext.WeightDatum.Remove(wgtData);
                m_DbContext.SaveChanges();
            }
        }
    }
}