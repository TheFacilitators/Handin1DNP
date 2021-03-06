
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Handin1.Data
{
    public class AdultsData :IAdultsData
    {
        private IList<Adult> adults;
        private FileContext file;

        public AdultsData()
        {
            file = new FileContext();
            adults = file.Adults;
        }

        public IList<Adult> GetAllAdults()
        {
            return adults;
        }

        public Adult GetAdultById(int id)
        {
            return adults.FirstOrDefault(a => a.Id == id);
        }

        public void EditAdult(Adult adult)
        {
            file.EditAdult(adult);
        }

        public void RemoveAdult(int id)
        {
            file.RemoveAdult(GetAdultById(id));
        }

        public void AddAdult(Adult adult)
        {
            file.AddAdult(adult);
        }
    }
}
