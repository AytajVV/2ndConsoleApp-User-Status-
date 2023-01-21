using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public bool Create(User entity)
        {
            try
            {
                AppDbContext.Users.Add(entity);
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(User entity)
        {
            try
            {
                AppDbContext.Users.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User Get(Predicate<User> filter = null)
        {
            try
            {
                return filter == null ? AppDbContext.Users[0] : AppDbContext.Users.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<User> GetAll(Predicate<User> filter = null)
        {
            try
            {
                return filter == null ? AppDbContext.Users : AppDbContext.Users.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(User entity)
        {
            try
            {
                User existUser = Get(u => u.Id == entity.Id);
                if (existUser != null)
                {
                    existUser = entity;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
