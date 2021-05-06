using FoodThy.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodThy.Application.Interfaces
{
    public interface IUser
    {
        Task CreateUser(TblUsuario user);
        Task<IEnumerable<TblUsuario>> GetUsers();
    }
}
