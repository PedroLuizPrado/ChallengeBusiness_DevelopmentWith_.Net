using ChallengeSprint01.Dtos;
using ChallengeSprint01.Models;

namespace ChallengeSprint01.Reposytorys.Interfaces
{
    public interface IUserAut
    {
        Task<User> GetUserByEmail(UserLoginDto request);

        Task<User> CreateUser(UserRegisterDto request);


        void DeleteUser(int id);

    }
}
