using System.Collections.Generic;
using Models;

namespace Handin1.Data
{
    public interface IAdultsData
    {
        IList<Adult> GetAllAdults();

        void EditAdult(Adult adult);

        Adult GetAdultById(int id);

        void RemoveAdult(int id);

        void AddAdult(Adult adult);
    }
}