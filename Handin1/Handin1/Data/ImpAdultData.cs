using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace Handin1.Data {
    public class ImpAdultData : IAdultData {

        private IList<Adult> adults;
        private FileContext persistence;

        public ImpAdultData() {
            persistence = new FileContext();
            adults = persistence.Adults;
        }
        
        
        public IList<Adult> GetAdults() {
            return adults;
        }

        public void AddAdult(Adult adult) {
            int max = adults.Max(a => a.Id);
            adult.Id = ++max;
            persistence.AddAdult(adult);
        }

        public void EditAdult(Adult adult) {
            persistence.EditAdult(adult);
        }

        public void RemoveAdult(int id) {
            persistence.RemoveAdult(id);
        }

        public Adult GetById(int id) {
            return adults.First(a => a.Id == id);
        }
    }
}