using FoodThy.Application.Interfaces;
using FoodThy.Application.Models;
using FoodThy.Domain.DataContexts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FoodThy.Domain.Repositories
{
    public class UserRepository : IUser
    {
        readonly FoodThyContext _context;
        public UserRepository(FoodThyContext context)
        {
            _context = context;
        }
        public async Task CreateUser(TblUsuario user)
        {
            try
            {
                _context.TblUsuarios.Add(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                
            }
        }

        public async Task<IEnumerable<TblUsuario>> GetUsers()
        {
            var query = from Users in _context.TblUsuarios
                        select Users;

            return await query.ToListAsync();
        }
    }
}
