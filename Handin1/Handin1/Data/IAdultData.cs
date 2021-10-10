using System.Collections.Generic;
using Models;

namespace Handin1.Data {
    public interface IAdultData {

        IList<Adult> GetAdults();

        void AddAdult(Adult adult);

        void EditAdult(Adult adult);

        void RemoveTodo(int id);
    }
}