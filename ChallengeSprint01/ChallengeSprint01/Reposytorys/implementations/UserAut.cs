using ChallengeSprint01.Data;
using ChallengeSprint01.Dtos;
using ChallengeSprint01.Models;
using ChallengeSprint01.Reposytorys.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace ChallengeSprint01.Reposytorys.implementations
{
    public class UserAut : IUserAut
    {
        private readonly DataContext _dataContext;
        public UserAut(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<User> CreateUser(UserRegisterDto request)
        {
            var getUser = await _dataContext.Users.FirstOrDefaultAsync(x=> x.email ==request.email);
            if (getUser == null) 
            {
                User newUser = new User
                {
                    email = request.email,
                    password = BCrypt.Net.BCrypt.HashPassword(request.password),
                    Name = request.Name,
                    cpf = request.cpf

                };
                _dataContext.Users.Add(newUser);
                _dataContext.SaveChanges();

                return newUser;
            
            }

            return getUser;
        }

        public void DeleteUser(int id)
        {
           var user = _dataContext.Users.FirstOrDefault( x = x => x.id == id);
            if (user != null) 
            {
                user.isActive = false;
            }
        }

        public async Task<User> GetUserByEmail(UserLoginDto request)
        {
            var getUser = await _dataContext.Users.FirstOrDefaultAsync(x => x.email == request.email);
            if (getUser == null)
            {
                return null;
            }
            if (BCrypt.Net.BCrypt.Verify(request.password, getUser.password)) 
            { 

                if (!getUser.isActive)
                {
                return getUser ;
                }

                return null;
            }
            return null;
        }
    }
}
