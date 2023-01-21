using Business.Interfaces;
using DataAccess;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserService : IUser
    {
        private readonly UserRepository userRepository;
        public static int id { get; set; } = 1;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        public User Create(User user)
        {
            try
            {
                User existUser = userRepository.Get(u => u.Username == user.Username);
                if (existUser == null)
                {
                    user.Id = id;
                    if (userRepository.Create(user))
                    {
                        id++;
                        return user;
                    }

                }
                return null;
                Console.WriteLine("Already exist! ");

            }
            catch (Exception)
            {

                throw;
            }

        }

        public User Delete(int? id)
        {
            try
            {
                User existUser = userRepository.Get(u => u.Id == id);
                if (existUser!=null)
                {
                    userRepository.Delete(existUser);
                    return existUser;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User FilterStatusByDate(int? id, DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllStatuses()
        {
            try
            {
                return userRepository.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public User GetStatusById(int? id)
        {
            try
            {
                User existUser = userRepository.Get(u => u.Id == id);
                if (existUser!=null)
                {
                    return existUser;

                }
                return null;
                Console.WriteLine("Not found!");

            }
            catch (Exception)
            {

                throw;
            }
        }

       

        public User ShareStatus(Status status)
        {
            try
            {
                AppDbContext.Statuses.Add(status);
                return null; ;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public User Update(int? id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
