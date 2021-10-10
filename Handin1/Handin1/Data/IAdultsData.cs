using System.Collections.Generic;
using Models;

namespace Handin1.Data
{
    public interface IAdultsData
    {
        IList<Adult> GetAllAdults();

        void EditAdult(int id);

        Adult GetAdultById(int id);
    }
}